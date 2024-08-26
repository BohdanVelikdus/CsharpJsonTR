using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TRCS
{
   
    internal class VideoGame
    {
        public string Title {  get; init; }
        public int ReleaseYear {  get; init; }
        public decimal Rating { get; init; }

        public VideoGame() { 
            
        }

        public override string ToString()
        {
            string res = Title + ":\n\tRelease year: " + ReleaseYear + "\n\tRating: " + Rating;
            return res;
        }
    }
}
