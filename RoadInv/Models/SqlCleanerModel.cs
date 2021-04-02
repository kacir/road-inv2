using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoadInv.Models
{
    public class SqlCleanerModel
    {
        public bool clean(string inputString)
        {
            string[] invalidCharacters = {";", "DELETE", "UPDATE", "SELECT", "UPDATE", "JOIN" };

            foreach(var item in invalidCharacters)
            {
                if (inputString.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
