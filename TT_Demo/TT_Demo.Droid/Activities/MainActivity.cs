using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using TT_Demo.Droid.Activities;

namespace TT_Demo.Droid
{
	[Activity (Label = "TT_Demo.Droid", Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
        List<Player> str = new List<Player>();
        ListView playerList;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			playerList = FindViewById<ListView>(Resource.Id.playerList);
            str.Add(new Player() {ImageURL = "http://www.freedigitalphotos.net/images/img/homepage/87357.jpg", Firstname = "Ganesan", TotalPlayed = "10", TotalWin = "5", TotalLost = "5" });
            str.Add(new Player() {ImageURL = "http://i.dailymail.co.uk/i/pix/2016/03/22/13/32738A6E00000578-3504412-image-a-6_1458654517341.jpg", Firstname = "Dhilip", TotalPlayed = "15", TotalWin = "10", TotalLost = "5" });
            str.Add(new Player() { ImageURL= "http://www.asriran.com/files/fa/news/1395/2/29/585800_411.jpg", Firstname = "Sarath", TotalPlayed = "6", TotalWin = "4", TotalLost = "2" });

            CustomPlayerCell adap = new CustomPlayerCell(this, str);
            playerList.Adapter = adap;

            playerList.ItemClick += PlayerList_ItemClick;

        }

        private void PlayerList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent intent = new Intent(this, typeof(PlayerMatchDetailsActivity));
            StartActivity(intent);
        }
    }
}


