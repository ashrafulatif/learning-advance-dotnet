using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LabTask1.Models;

namespace LabTask1.ViewModel
{
    public class SampleViewModel
    {
        public List<Player> Player{ get; set; }
        public List<Staff> Staff { get; set; }
        public List<Stadium> Stadium{ get; set; }

    }
}