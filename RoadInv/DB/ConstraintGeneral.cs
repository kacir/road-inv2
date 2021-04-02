using System;
using System.Collections.Generic;

#nullable disable

namespace RoadInv.DB
{
    public partial class ConstraintGeneral
    {
        public int Id { get; set; }
        public string Domainvalue { get; set; }
        public string Label { get; set; }
        public string ValueDescription { get; set; }
        public string DomainName { get; set; }
    }
}
