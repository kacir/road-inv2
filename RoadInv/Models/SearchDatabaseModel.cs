using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RoadInv.Models
{
    public class SearchDatabaseModel
    {
        //private static string connectionString = "Data Source=invsql-dev;Initial Catalog=roadinv;User ID=roadinv_program;Password=yellow99_ZZ$";
        private string _connection;
        public List<SegmentModel> search(string district = "", int county = 0, string route = "", string section = "", string direction = "", decimal logmile = -1)
        {
            SqlConnection cnn = new SqlConnection(_connection);
            cnn.Open();

            string queryString;

            string logmileString;
            if (logmile == -1)
            {
                logmileString = "";
            } else
            {
                logmileString = " AND ([AH_ELM] >= " + logmile.ToString() +  " AND [AH_BLM] <= " + logmile.ToString() + " )";
            }

            if (county == 0)
            {
                queryString = String.Format(
                    "SELECT TOP (1000) [ID], [AH_District], [systemStatus], [AH_District], [AH_County], [AH_Route], [AH_Section], [LOG_DIRECT], [AH_BLM], [AH_ELM], [AH_Length], [RouteSign], [TypeRoad], [FuncClass], [NHS] FROM [roadinv].[dbo].[RoadInv] WHERE [AH_Route] LIKE '%{0}%' AND [AH_Section] LIKE '%{1}%' AND [AH_District] LIKE '%{2}%' {3} ORDER BY [RouteSign], [AH_RoadID], [AH_BLM]",
                    route,
                    section,
                    district,
                    logmileString
                );
            } else
            {
                queryString = String.Format(
                    "SELECT TOP (1000) [ID], [AH_District], [systemStatus], [AH_District], [AH_County], [AH_Route], [AH_Section], [LOG_DIRECT], [AH_BLM], [AH_ELM], [AH_Length], [RouteSign], [TypeRoad], [FuncClass], [NHS] FROM [roadinv].[dbo].[RoadInv] WHERE [AH_County] = {0} AND [AH_Route] LIKE '%{1}%' AND [AH_Section] LIKE '%{2}%' {3} AND [AH_District] LIKE '%{2}%' ORDER BY [RouteSign], [AH_RoadID], [AH_BLM]",
                county.ToString(),
                 route,
                section,
                district,
                logmileString
                );
            }


            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            ArrayList output2 = new ArrayList();
            List<SegmentModel> output3 = new List<SegmentModel>();
            while (dataReader.Read())
            {
                SegmentModel temp = new SegmentModel();
                temp.ID = int.Parse(dataReader.GetValue(0).ToString());
                temp.AH_District = dataReader.GetValue(1).ToString();
                temp.SystemStatus = dataReader.GetValue(2).ToString();
                temp.AH_District = dataReader.GetValue(3).ToString();
                temp.AH_County = dataReader.GetValue(4).ToString();
                temp.AH_Route = dataReader.GetValue(5).ToString();
                temp.AH_Section = dataReader.GetValue(6).ToString();
                temp.LOG_DIRECT = dataReader.GetValue(7).ToString();
                temp.AH_BLM = (decimal)dataReader.GetValue(8);
                temp.AH_ELM = (decimal)dataReader.GetValue(9);
                temp.AH_Length = (decimal)dataReader.GetValue(10);
                temp.TypeRoad = dataReader.GetValue(11).ToString();
                temp.RouteSign = dataReader.GetValue(12).ToString();
                temp.FuncClass = dataReader.GetValue(13).ToString();
                temp.NHS = dataReader.GetValue(14).ToString();

                output3.Add(temp);
            }
            cnn.Close();
            return output3;
        }

        public ArrayList CountyList() {
            //first time is county name string, second is the ArDOT number
            SqlConnection cnn = new SqlConnection(_connection);
            cnn.Open();

            string queryString = "SELECT [County], [CountyNumber] FROM [roadinv].[dbo].[Constaint_County]";
            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            ArrayList temp = new ArrayList();
            while (dataReader.Read())
            {
                string[] record = {dataReader.GetString(0), dataReader.GetString(1)};
                temp.Add(record);
            }

            cnn.Close();


            return temp;
        }
        public SegmentModel segementDetails(int ID)
        {
            SegmentModel resultSegement = new SegmentModel();

            SqlConnection cnn = new SqlConnection(_connection);
            cnn.Open();

            string queryString = @"SELECT [ID],[AH_District]
            ,[AH_County], [AH_Route], [AH_Section], [LOG_DIRECT], [AH_RoadID], [GovermentCode], [RuralUrbanArea], [UrbanAreaCode], [FuncClass]
            ,[NHS], [SystemStatus], [SpecialSystems], [BothDirectionNumLanes], [OneDirectionNumLanes], [Comment1], [TypeRoad], [RouteSign]
            ,[APHN], [Access], [TypeOperation], [YearBuilt], [YearRecon], [MedianWidth], [LaneWidth], [SurfaceWidth], [RightShoulderSurface]
            ,[LeftShoulderSurface], [RightShoulderWidth], [LeftShoulderWidth], [RoadwayWidth], [ExtraLanes], [MedianType], [SurfaceType]
            ,[Alternative_Route_Name], [AH_BLM], [AH_ELM], [AH_Length] FROM[roadinv].[dbo].[RoadInv] WHERE [ID] = " + ID.ToString();

            SqlCommand command = new SqlCommand(queryString, cnn);
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                resultSegement.ID = int.Parse( dataReader.GetValue(0).ToString());
                resultSegement.AH_District = dataReader.GetValue(1).ToString();
                resultSegement.AH_County = dataReader.GetValue(2).ToString();
                resultSegement.AH_Route = dataReader.GetValue(3).ToString();
                resultSegement.AH_Section = dataReader.GetValue(4).ToString();
                resultSegement.LOG_DIRECT = dataReader.GetValue(5).ToString();
                resultSegement.AH_RoadID = dataReader.GetValue(6).ToString();
                resultSegement.GovermentCode = dataReader.GetValue(7).ToString();
                resultSegement.RuralUrbanArea = dataReader.GetValue(8).ToString();
                resultSegement.UrbanAreaCode = dataReader.GetValue(9).ToString();
                resultSegement.FuncClass = dataReader.GetValue(10).ToString();
                resultSegement.NHS = dataReader.GetValue(11).ToString();
                resultSegement.SystemStatus = dataReader.GetValue(12).ToString();
                resultSegement.SpecialSystems = dataReader.GetValue(13).ToString();
                resultSegement.BothDirectionNumLanes = dataReader.GetValue(14).ToString();
                resultSegement.OneDirectionNumLanes = dataReader.GetValue(15).ToString();
                resultSegement.Comment1 = dataReader.GetValue(16).ToString();
                resultSegement.TypeRoad = dataReader.GetValue(17).ToString();
                resultSegement.RouteSign = dataReader.GetValue(18).ToString();
                resultSegement.APHN = dataReader.GetValue(19).ToString();
                resultSegement.Access = dataReader.GetValue(20).ToString();
                resultSegement.TypeOperation = dataReader.GetValue(21).ToString();
                resultSegement.YearBuilt = dataReader.GetValue(22).ToString();
                resultSegement.yearRecon = dataReader.GetValue(23).ToString();
                resultSegement.MedianWidth = dataReader.GetValue(24).ToString();
                resultSegement.LaneWidth = dataReader.GetValue(25).ToString();
                resultSegement.SurfaceWidth = int.Parse( dataReader.GetValue(26).ToString());
                resultSegement.RightShoulderSurface = dataReader.GetValue(27).ToString();
                resultSegement.LeftShoulderSurface = dataReader.GetValue(28).ToString();
                resultSegement.RightShoulderWidth = int.Parse( dataReader.GetValue(29).ToString());
                resultSegement.LeftShoulderWidth = int.Parse(dataReader.GetValue(30).ToString());
                resultSegement.RoadwayWidth = int.Parse( dataReader.GetValue(31).ToString());
                resultSegement.ExtraLanes = dataReader.GetValue(32).ToString();
                resultSegement.MedianType = dataReader.GetValue(33).ToString();
                resultSegement.SurfaceType = dataReader.GetValue(34).ToString();
                resultSegement.Alternative_Route_Name = dataReader.GetValue(35).ToString();
                resultSegement.AH_BLM = decimal.Parse( dataReader.GetValue(36).ToString());
                resultSegement.AH_ELM = decimal.Parse(dataReader.GetValue(37).ToString());
                resultSegement.AH_Length = decimal.Parse(dataReader.GetValue(38).ToString());
            }

            cnn.Close();

            return resultSegement;
        }

        public SearchDatabaseModel(string connection)
        {
            _connection = connection;
        }

        public int NewRecord (SegmentModel seg){

            string queryString;

            queryString = @"UPDATE dbo.RoadInv
SET [AH_District] = @AH_District,
[AH_County] = @AH_County,
[AH_Route] = @AH_Route,
[AH_Section] = @AH_Section,
[LOG_DIRECT] = @LOG_DIRECT,
[GovermentCode] = @GovermentCode,
[RuralUrbanArea] = @RuralUrbanArea,
[UrbanAreaCode] = @UrbanAreaCode,
[FuncClass] = @FuncClass,
[NHS] = @NHS,
[SystemStatus] = @SystemStatus,
[SpecialSystems] = @SpecialSystems,
[BothDirectionNumLanes] = @BothDirectionNumLanes,
[OneDirectionNumLanes] = @OneDirectionNumLanes,
[Comment1] = @Comment1,
[TypeRoad] = @TypeRoad,
[RouteSign] = @RouteSign,
[APHN] = @APHN,
[Access] = @Access,
[TypeOperation] = @TypeOperation,
[YearBuilt] = @YearBuilt,
[YearRecon] = @YearRecon,
[MedianWidth] = @MedianWidth,
[LaneWidth] = @LaneWidth,
[SurfaceWidth] = @SurfaceWidth,
[RightShoulderSurface] = @RightShoulderSurface,
[LeftShoulderSurface] = @LeftShoulderSurface,
[RightShoulderWidth] = @RightShoulderWidth,
[LeftShoulderWidth] = @LeftShoulderWidth,
[RoadwayWidth] = @RoadwayWidth,
[ExtraLanes] = @ExtraLanes,
[MedianType] = @MedianType,
[SurfaceType] = @SurfaceType,
[Alternative_Route_Name] = @Alternative_Route_Name,
[AH_BLM] = @AH_BLM,
[AH_ELM] = @AH_ELM
WHERE[ID] = @ID; ";

            SqlConnection cnn = new SqlConnection(_connection);
            cnn.Open();

            SqlCommand command = new SqlCommand(queryString, cnn);
            command.Parameters.Add("@AH_District", System.Data.SqlDbType.VarChar);
            command.Parameters["@AH_District"].Value = seg.AH_District;

            command.Parameters.Add("@AH_County", SqlDbType.VarChar);
            command.Parameters["@AH_County"].Value = seg.AH_County;

            command.Parameters.Add("@AH_Route", SqlDbType.VarChar);
            command.Parameters["@AH_Route"].Value = seg.AH_Route;

            command.Parameters.Add("@AH_Section", SqlDbType.VarChar);
            command.Parameters["@AH_Section"].Value = seg.AH_Section;

            command.Parameters.Add("@LOG_DIRECT", SqlDbType.VarChar);
            command.Parameters["@LOG_DIRECT"].Value = seg.LOG_DIRECT;

            command.Parameters.Add("@GovermentCode", SqlDbType.VarChar);
            command.Parameters["@GovermentCode"].Value = seg.GovermentCode;

            command.Parameters.Add("@RuralUrbanArea", SqlDbType.VarChar);
            command.Parameters["@RuralUrbanArea"].Value = seg.RuralUrbanArea;

            command.Parameters.Add("@UrbanAreaCode", SqlDbType.VarChar);
            command.Parameters["@UrbanAreaCode"].Value = seg.UrbanAreaCode;

            command.Parameters.Add("@FuncClass", SqlDbType.VarChar);
            command.Parameters["@FuncClass"].Value = seg.FuncClass;

            command.Parameters.Add("@NHS", SqlDbType.VarChar);
            command.Parameters["@NHS"].Value = seg.NHS;

            command.Parameters.Add("@SystemStatus", SqlDbType.VarChar);
            command.Parameters["@SystemStatus"].Value = seg.SystemStatus;

            command.Parameters.Add("@SpecialSystems", SqlDbType.VarChar);
            command.Parameters["@SpecialSystems"].Value = seg.SpecialSystems;

            command.Parameters.Add("@BothDirectionNumLanes", SqlDbType.VarChar);
            command.Parameters["@BothDirectionNumLanes"].Value = seg.BothDirectionNumLanes;

            command.Parameters.Add("@OneDirectionNumLanes", SqlDbType.VarChar);
            command.Parameters["@OneDirectionNumLanes"].Value = seg.OneDirectionNumLanes;

            command.Parameters.Add("@Comment1", SqlDbType.VarChar);
            command.Parameters["@Comment1"].Value = seg.Comment1;

            command.Parameters.Add("@TypeRoad", SqlDbType.VarChar);
            command.Parameters["@TypeRoad"].Value = seg.TypeRoad;

            command.Parameters.Add("@RouteSign", SqlDbType.VarChar);
            command.Parameters["@RouteSign"].Value = seg.RouteSign;

            command.Parameters.Add("@APHN", SqlDbType.VarChar);
            command.Parameters["@APHN"].Value = seg.APHN;

            command.Parameters.Add("@Access", SqlDbType.VarChar);
            command.Parameters["@Access"].Value = seg.Access;

            command.Parameters.Add("@TypeOperation", SqlDbType.VarChar);
            command.Parameters["@TypeOperation"].Value = seg.TypeOperation;

            command.Parameters.Add("@YearBuilt", SqlDbType.VarChar);
            command.Parameters["@YearBuilt"].Value = seg.YearBuilt;

            command.Parameters.Add("@YearRecon", SqlDbType.VarChar);
            command.Parameters["@YearRecon"].Value = seg.yearRecon;

            command.Parameters.Add("@MedianWidth", SqlDbType.VarChar);
            command.Parameters["@MedianWidth"].Value = seg.MedianWidth;

            command.Parameters.Add("@LaneWidth", SqlDbType.Int);
            if (seg.LaneWidth == "")
            {
                command.Parameters["@LaneWidth"].Value = 0;
            } else
            {
                command.Parameters["@LaneWidth"].Value = int.Parse(seg.LaneWidth);
            }
            

            command.Parameters.Add("@SurfaceWidth", SqlDbType.Int);
            command.Parameters["@SurfaceWidth"].Value = seg.SurfaceWidth;

            command.Parameters.Add("@RightShoulderSurface", SqlDbType.VarChar);
            command.Parameters["@RightShoulderSurface"].Value = seg.RightShoulderSurface;

            command.Parameters.Add("@LeftShoulderSurface", SqlDbType.VarChar);
            command.Parameters["@LeftShoulderSurface"].Value = seg.LeftShoulderSurface;

            command.Parameters.Add("@RightShoulderWidth", SqlDbType.Int);
            command.Parameters["@RightShoulderWidth"].Value = seg.RightShoulderWidth;

            command.Parameters.Add("@LeftShoulderWidth", SqlDbType.Int);
            command.Parameters["@LeftShoulderWidth"].Value = seg.LeftShoulderWidth;

            command.Parameters.Add("@RoadwayWidth", SqlDbType.Int);
            command.Parameters["@RoadwayWidth"].Value = seg.RoadwayWidth;

            command.Parameters.Add("@ExtraLanes", SqlDbType.VarChar);
            command.Parameters["@ExtraLanes"].Value = seg.ExtraLanes;

            command.Parameters.Add("@MedianType", SqlDbType.VarChar);
            command.Parameters["@MedianType"].Value = seg.MedianType;

            command.Parameters.Add("@SurfaceType", SqlDbType.VarChar);
            command.Parameters["@SurfaceType"].Value = seg.SurfaceType;

            command.Parameters.Add("@Alternative_Route_Name", SqlDbType.VarChar);
            command.Parameters["@Alternative_Route_Name"].Value = seg.Alternative_Route_Name;

            command.Parameters.Add("@AH_BLM", SqlDbType.Decimal);
            command.Parameters["@AH_BLM"].Value = seg.AH_BLM;

            command.Parameters.Add("@AH_ELM", SqlDbType.Decimal);
            command.Parameters["@AH_ELM"].Value = seg.AH_ELM;

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = seg.ID;

            
            int rowsEffected = command.ExecuteNonQuery();

            cnn.Close();

            return rowsEffected;
    }

        public int NewRecord2(SegmentModel seg)
        {

            string queryString;

            queryString = @"UPDATE dbo.RoadInv
SET [AH_District] = @AH_District,
[AH_County] = @AH_County,
[AH_Route] = @AH_Route,
[AH_Section] = @AH_Section,
[LOG_DIRECT] = @LOG_DIRECT,
[GovermentCode] = @GovermentCode,
[RuralUrbanArea] = @RuralUrbanArea,
[UrbanAreaCode] = @UrbanAreaCode,
[FuncClass] = @FuncClass,
[NHS] = @NHS,
[SystemStatus] = @SystemStatus,
[SpecialSystems] = @SpecialSystems,
[BothDirectionNumLanes] = @BothDirectionNumLanes,
[OneDirectionNumLanes] = @OneDirectionNumLanes,
[Comment1] = @Comment1,
[TypeRoad] = @TypeRoad,
[RouteSign] = @RouteSign,
[APHN] = @APHN,
[Access] = @Access,
[TypeOperation] = @TypeOperation,
[YearBuilt] = @YearBuilt,
[YearRecon] = @YearRecon,
[MedianWidth] = @MedianWidth,
[LaneWidth] = @LaneWidth,
[SurfaceWidth] = @SurfaceWidth,
[RightShoulderSurface] = @RightShoulderSurface,
[LeftShoulderSurface] = @LeftShoulderSurface,
[RightShoulderWidth] = @RightShoulderWidth,
[LeftShoulderWidth] = @LeftShoulderWidth,
[RoadwayWidth] = @RoadwayWidth,
[ExtraLanes] = @ExtraLanes,
[MedianType] = @MedianType,
[SurfaceType] = @SurfaceType,
[Alternative_Route_Name] = @Alternative_Route_Name,
[AH_BLM] = @AH_BLM,
[AH_ELM] = @AH_ELM
WHERE[ID] = @ID; ";

            SqlConnection cnn = new SqlConnection(_connection);
            cnn.Open();

            SqlCommand command = new SqlCommand(queryString, cnn);
            command.Parameters.Add("@AH_District", System.Data.SqlDbType.VarChar);
            command.Parameters["@AH_District"].Value = seg.AH_District;

            command.Parameters.Add("@AH_County", SqlDbType.VarChar);
            command.Parameters["@AH_County"].Value = seg.AH_County;

            command.Parameters.Add("@AH_Route", SqlDbType.VarChar);
            command.Parameters["@AH_Route"].Value = seg.AH_Route;

            command.Parameters.Add("@AH_Section", SqlDbType.VarChar);
            command.Parameters["@AH_Section"].Value = seg.AH_Section;

            command.Parameters.Add("@LOG_DIRECT", SqlDbType.VarChar);
            command.Parameters["@LOG_DIRECT"].Value = seg.LOG_DIRECT;

            command.Parameters.Add("@GovermentCode", SqlDbType.VarChar);
            command.Parameters["@GovermentCode"].Value = seg.GovermentCode;

            command.Parameters.Add("@RuralUrbanArea", SqlDbType.VarChar);
            command.Parameters["@RuralUrbanArea"].Value = seg.RuralUrbanArea;

            command.Parameters.Add("@UrbanAreaCode", SqlDbType.VarChar);
            command.Parameters["@UrbanAreaCode"].Value = seg.UrbanAreaCode;

            command.Parameters.Add("@FuncClass", SqlDbType.VarChar);
            command.Parameters["@FuncClass"].Value = seg.FuncClass;

            command.Parameters.Add("@NHS", SqlDbType.VarChar);
            command.Parameters["@NHS"].Value = seg.NHS;

            command.Parameters.Add("@SystemStatus", SqlDbType.VarChar);
            command.Parameters["@SystemStatus"].Value = seg.SystemStatus;

            command.Parameters.Add("@SpecialSystems", SqlDbType.VarChar);
            command.Parameters["@SpecialSystems"].Value = seg.SpecialSystems;

            command.Parameters.Add("@BothDirectionNumLanes", SqlDbType.VarChar);
            command.Parameters["@BothDirectionNumLanes"].Value = seg.BothDirectionNumLanes;

            command.Parameters.Add("@OneDirectionNumLanes", SqlDbType.VarChar);
            command.Parameters["@OneDirectionNumLanes"].Value = seg.OneDirectionNumLanes;

            command.Parameters.Add("@Comment1", SqlDbType.VarChar);
            command.Parameters["@Comment1"].Value = seg.Comment1;

            command.Parameters.Add("@TypeRoad", SqlDbType.VarChar);
            command.Parameters["@TypeRoad"].Value = seg.TypeRoad;

            command.Parameters.Add("@RouteSign", SqlDbType.VarChar);
            command.Parameters["@RouteSign"].Value = seg.RouteSign;

            command.Parameters.Add("@APHN", SqlDbType.VarChar);
            command.Parameters["@APHN"].Value = seg.APHN;

            command.Parameters.Add("@Access", SqlDbType.VarChar);
            command.Parameters["@Access"].Value = seg.Access;

            command.Parameters.Add("@TypeOperation", SqlDbType.VarChar);
            command.Parameters["@TypeOperation"].Value = seg.TypeOperation;

            command.Parameters.Add("@YearBuilt", SqlDbType.VarChar);
            command.Parameters["@YearBuilt"].Value = seg.YearBuilt;

            command.Parameters.Add("@YearRecon", SqlDbType.VarChar);
            command.Parameters["@YearRecon"].Value = seg.yearRecon;

            command.Parameters.Add("@MedianWidth", SqlDbType.VarChar);
            command.Parameters["@MedianWidth"].Value = seg.MedianWidth;

            command.Parameters.Add("@LaneWidth", SqlDbType.Int);
            command.Parameters["@LaneWidth"].Value = seg.LaneWidth;

            command.Parameters.Add("@SurfaceWidth", SqlDbType.Int);
            command.Parameters["@SurfaceWidth"].Value = seg.SurfaceWidth;

            command.Parameters.Add("@RightShoulderSurface", SqlDbType.VarChar);
            command.Parameters["@RightShoulderSurface"].Value = seg.RightShoulderSurface;

            command.Parameters.Add("@LeftShoulderSurface", SqlDbType.VarChar);
            command.Parameters["@LeftShoulderSurface"].Value = seg.LeftShoulderSurface;

            command.Parameters.Add("@RightShoulderWidth", SqlDbType.Int);
            command.Parameters["@RightShoulderWidth"].Value = seg.RightShoulderWidth;

            command.Parameters.Add("@LeftShoulderWidth", SqlDbType.Int);
            command.Parameters["@LeftShoulderWidth"].Value = seg.LeftShoulderWidth;

            command.Parameters.Add("@RoadwayWidth", SqlDbType.Int);
            command.Parameters["@RoadwayWidth"].Value = seg.RoadwayWidth;

            command.Parameters.Add("@ExtraLanes", SqlDbType.VarChar);
            command.Parameters["@ExtraLanes"].Value = seg.ExtraLanes;

            command.Parameters.Add("@MedianType", SqlDbType.VarChar);
            command.Parameters["@MedianType"].Value = seg.MedianType;

            command.Parameters.Add("@SurfaceType", SqlDbType.VarChar);
            command.Parameters["@SurfaceType"].Value = seg.SurfaceType;

            command.Parameters.Add("@Alternative_Route_Name", SqlDbType.VarChar);
            command.Parameters["@Alternative_Route_Name"].Value = seg.Alternative_Route_Name;

            command.Parameters.Add("@AH_BLM", SqlDbType.Decimal);
            command.Parameters["@AH_BLM"].Value = seg.AH_BLM;

            command.Parameters.Add("@AH_ELM", SqlDbType.Decimal);
            command.Parameters["@AH_ELM"].Value = seg.AH_ELM;

            command.Parameters.Add("@ID", SqlDbType.Int);
            command.Parameters["@ID"].Value = seg.ID;


            int rowsEffected = command.ExecuteNonQuery();

            cnn.Close();

            return rowsEffected;
        }

    }
}
