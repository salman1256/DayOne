using System;
using System.Collections.Generic;

namespace ServiceTwo.Models
{
    public partial class Player
    {
        public int Pid { get; set; }
        public string? Pname { get; set; }
        public double? Pavg { get; set; }
        public string? Ptype { get; set; }
    }
}
