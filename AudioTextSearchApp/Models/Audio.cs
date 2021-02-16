using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AudioTextSearchApp.Models
{
    public class Audio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }

        public Audio() 
        {
            
        }
    }
}
