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
using Android.Graphics;
using System.Net;

namespace TT_Demo.Droid.Activities
{
    class CustomPlayerCell : BaseAdapter<Player>
    {
        public List<Player> mItem;
        private Context context;
        public override int Count
        {
            get
            {
                return mItem.Count;
            }
        }

        public CustomPlayerCell(Context Ccontext, List<Player> Items)
        {
            context = Ccontext;
            mItem = Items;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(context).Inflate(Resource.Layout.PlayerCell, null, false);
            }
            //ImageView imageView = row.FindViewById<ImageView>(Resource.Id.imageView);         
            //var imageBitmap = GetImageBitmapFromUrl(mItem[position].ImageURL);
            //imageView.SetImageBitmap(imageBitmap);

            TextView lblFirstName = row.FindViewById<TextView>(Resource.Id.lblFirstName);

            lblFirstName.Text = mItem[position].Firstname;

            TextView lblTotalPlayes = row.FindViewById<TextView>(Resource.Id.lblTotalPlayed);

            lblTotalPlayes.Text = mItem[position].TotalPlayed;

            TextView lblTotalWin = row.FindViewById<TextView>(Resource.Id.lblTotalWin);

            lblTotalWin.Text = mItem[position].TotalPlayed;

            TextView lblTotalLost = row.FindViewById<TextView>(Resource.Id.lblTotalLost);

            lblTotalLost.Text = mItem[position].TotalPlayed;

            return row;


        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Player this[int position]
        {
            get
            {
                return mItem[position];
            }
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }
    }
}