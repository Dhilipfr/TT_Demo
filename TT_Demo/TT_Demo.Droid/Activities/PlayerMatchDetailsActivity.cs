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
    [Activity(Label = "PlayerMatchDetailsActivity")]
    public class PlayerMatchDetailsActivity : Activity
    {
        List<Player> str = new List<Player>();
        ListView playerList;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.PlayerMatchDetails);

            playerList = FindViewById<ListView>(Resource.Id.playerList);
            str.Add(new Player() { ImageURL = "http://www.freedigitalphotos.net/images/img/homepage/87357.jpg", Firstname = "Ganesan", TotalPlayed = "10", TotalWin = "5", TotalLost = "5" });
            str.Add(new Player() { ImageURL = "http://i.dailymail.co.uk/i/pix/2016/03/22/13/32738A6E00000578-3504412-image-a-6_1458654517341.jpg", Firstname = "Dhilip", TotalPlayed = "15", TotalWin = "10", TotalLost = "5" });
            str.Add(new Player() { ImageURL = "http://www.asriran.com/files/fa/news/1395/2/29/585800_411.jpg", Firstname = "Sarath", TotalPlayed = "6", TotalWin = "4", TotalLost = "2" });

            CustomPlayerCell adap = new CustomPlayerCell(this, str);
            playerList.Adapter = adap;
        }
    }
}