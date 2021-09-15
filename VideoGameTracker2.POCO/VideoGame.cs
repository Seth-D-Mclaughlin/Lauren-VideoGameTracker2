using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameTracker2.POCO
{
    public class VideoGame
    {
        private string _name;
        public string Name {
            get
            {
                InitialRelease = DateTime.Now;
                return _name;
            }
            set {
                _name = value;
            } 
        }
        
        public DateTime InitialRelease { get; set; }

        public VideoGame(string name, DateTime release)
        {
            Name = name;
            InitialRelease = release;
        }
    }
}
