using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TT_Demo.Droid.Activities
{
    class Player
    {
        public string ImageURL { get; set; }
        public string Firstname { get; set; }
        public string TotalPlayed { get; set; }
        public string TotalWin { get; set; }
        public string TotalLost { get; set; }
    }
}