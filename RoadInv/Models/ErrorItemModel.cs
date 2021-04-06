using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class ErrorItemModel
        //represents a single error during validation
    {
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
            ErrorMessageSort = errorMessageSort;//short error message for easy display in interface
            ErrorMessageLong = errorMessageLong;// More detailed error description 
            Fields = fields;// List of fields that the error relates to. Could be one error or multiple.
        }

        public string ErrorMessageSort { set; get; }
        public string ErrorMessageLong { set; get; }
        public List<string> Fields { set; get; }
    }
}
