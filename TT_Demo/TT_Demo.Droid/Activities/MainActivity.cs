using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using TT_Demo.Droid.Activities;
using TT_Demo.BL;

namespace TT_Demo.Droid
{
	[Activity (Label = "TT_Demo.Droid", Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{        
        ListView playerList;

        BLMatchDetails matchDetails = new BLMatchDetails();

        protected override async void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

            await matchDetails.GetMatchDetails();

			// Get our button from the layout resource,
			// and attach an event to it
			playerList = FindViewById<ListView>(Resource.Id.playerList);
            
            CustomPlayerCell adap = new CustomPlayerCell(this, matchDetails.MatchInfo);
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


