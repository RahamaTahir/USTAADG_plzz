using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ustaad_G_Service1
{
    public class Admin
    {
        private static string profit = "0";

        public static List<string> ratings = new List<string>();

        public static string Profit { get => profit; set => profit = value; }

        public static void addRating(string rating)
        {
            ratings.Add(rating);
        }


        public string Calculate_rating()
        {
            int stars = 0;
            int i = 0;
            foreach (string s in Admin.ratings)
            {
                int val = int.Parse(Admin.ratings.ElementAt(i));
                stars = stars + val;
                i++;
            }
            stars = stars / Admin.ratings.Count;
            string x = stars.ToString();
            return x;
        }
    }
}