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
using TT_Demo.BL;

namespace TT_Demo.Droid.Activities
{
    [Activity(Label = "PlayerMatchDetailsActivity")]
    public class PlayerMatchDetailsActivity : Activity
    {        
        ListView playerList;

        BLMatchDetails matchDetails = new BLMatchDetails();
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            await matchDetails.GetMatchDetails();

            // Create your application here
            SetContentView(Resource.Layout.PlayerMatchDetails);

            playerList = FindViewById<ListView>(Resource.Id.playerList);
            
            CustomPlayerCell adap = new CustomPlayerCell(this, matchDetails.MatchInfo);
            playerList.Adapter = adap;
        }
    }
}