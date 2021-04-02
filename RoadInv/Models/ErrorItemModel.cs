using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class ErrorItemModel
    {

        public static string[] validCounty = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", 
            "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", 
            "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "75" };
        public static string[] validDistrict = { "1", "2", "3", "4", "5", "6", "7" };
        public static Dictionary<string, string> validDistrictCountyPair = new Dictionary<string, string> { { "60", "6" } };
        public static string[] validGovermentCode = { "01", "02", "04", "60", "63", "64", "66", "70", "72", "73", "74", "80", "21" };
        public static string[] validRouteSign = { "1", "2", "3", "4", "5", "6" };
        public static string[] validRuralUrbanArea = { "1", "2", "3", "4" };
        public static string[] validUrbanAreaCode = { "00000", "30925", "43345", "56116", "87193", "29494", "40213", "50392", "69454" };
        public static Dictionary<string, string> validUrbanCountyPair = new Dictionary<string, string> { { "5", "29494" }, { "72", "69454" }, { "60", "50392" } };
        public static string[] validFuncClass = { "1", "2", "3", "4", "5", "6", "7" };
        public static string[] validSystemStatus = { "1", "2", "3" };
        public static string[] validTypeRoad = { "1", "3", "5", "6", "7", "8" };
        public static string[] validMedianType = { "0", "1", "2", "3", "4", "5" };
        public static string[] validTypeOperation = { "1", "2", "3", "4" };
        public static string[] validAccess = { "1", "2", "3" };
        public static string[] validAPHN = { "0", "1", "2", "3", "4" };
        public static string[] validNHS = { "0", "1", "2", "3", "3", "4", "5", "6", "7", "8" };
        public static string[] validSpecialSystems = { "1", "3", "4", "5", "6", "7", "9" };
        public static string[] validShoulderSurface = { "0", "1", "2", "3", "4", "5", "6" };
        public static string[] validExtraLanes = { "0", "1", "2", "3", "4", "5", "6", "7" };
        public static string[] validSurfaceType = { "0", "1", "2", "4", "6" };

        public static char[] validCharacters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7', '8', '9'};

        public static List<string> checkInvalidCharacters(string focusString)
        {
            List<string> temp = new List<string>();
            foreach (char focusChar in focusString)
            {
                if (!validCharacters.Contains(focusChar)){
                    temp.Add(focusChar.ToString());
                }
            }
            return temp;

        }

        public ErrorItemModel(string errorMessageSort, string errorMessageLong, List<string> fields)
        {
            ErrorMessageSort = errorMessageSort;
            ErrorMessageLong = errorMessageLong;
            Fields = fields;
        }

        public string ErrorMessageSort { set; get; }
        public string ErrorMessageLong { set; get; }
        public List<string> Fields { set; get; }
    }
}
