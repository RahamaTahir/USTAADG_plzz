using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class Admin
    {
        public static List<string> ratings = new List<string>();

        public static void addRating(string rating)
        {
            ratings.Add(rating);
        }
    }
}