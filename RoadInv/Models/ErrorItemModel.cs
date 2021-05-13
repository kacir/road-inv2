using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class ErrorItemModel
        //represents a single error during validation
    {
        public ErrorItemModel(string errorMessageSort, string errorMessageLong, List<string> fields)
        {
            ErrorMessageSort = errorMessageSort;//short error message for easy display in interface
            ErrorMessageLong = errorMessageLong;// More detailed error description 
            Fields = fields;// List of fields that the error relates to. Could be one error or multiple.
        }

        public string ErrorMessageSort { set; get; }
        public string ErrorMessageLong { set; get; }
        public List<string> Fields { set; get; }
    }
}
