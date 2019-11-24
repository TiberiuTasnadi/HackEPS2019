using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class ResultViewModel
    {
        [DisplayName("File")]
        public string FileName { get; set; }
        [DisplayName("Accuracy")]
        public float Accuracy { get; set; }        
        public string ImgPath { get; set; }
        [DisplayName("Result")]
        public string Category { get; set; }
    }
}
