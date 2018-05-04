using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class Admin
    {
        private string profit;

        public static List<string> ratings = new List<string>();

        public string Profit { get => profit; set => profit = value; }

        public static void addRating(string rating)
        {
            ratings.Add(rating);
        }
    }
}