using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ustaadG1
{
    class Admin
    {
        private int rating;

        public int Rating { get => rating; set => rating = value; }

        public int UpdateRating(string feedback);
    }
}
