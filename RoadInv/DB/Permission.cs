using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class Permission
    {
        public string UserId { get; set; }
        public int DatabaseId { get; set; }
        public string Nhsbulk { get; set; }
        public string FuncBulk { get; set; }
        public string Aphnbulk { get; set; }
    }
}
