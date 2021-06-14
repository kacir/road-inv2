using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    /// <summary>
    /// represents a single error during validation. It could effect multiple fields but only violate a single rule.
    /// </summary>
    public class SingleSegmentErrorItemModel
    {
        /// <summary>
        /// short error message for easy display in interface
        /// </summary>
        public string ErrorMessageSort { set; get; }
        /// <summary>
        /// More detailed error description 
        /// </summary>
        public string ErrorMessageLong { set; get; }
        /// <summary>
        /// List of fields that the error relates to. Could be one error or multiple.
        /// </summary>
        public List<string> Fields { set; get; }


        public SingleSegmentErrorItemModel(string errorMessageSort, string errorMessageLong, List<string> fields)
        {    
            ErrorMessageSort = errorMessageSort;
            ErrorMessageLong = errorMessageLong;
            Fields = fields;
        }
    }
}
