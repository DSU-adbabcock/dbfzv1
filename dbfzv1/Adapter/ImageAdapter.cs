using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace dbfzv1.Adapter
{
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter (Context c)
        {
            context = c;
        }

        public override int Count
        {
            get { return thumbIds.Length; }
        }

        public override Java.Lang.Object GetItem (int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(200, 150);
                imageView.SetScaleType(ImageView.ScaleType.FitXy);
                imageView.SetPadding(20, 5, 20, 5);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            imageView.SetImageResource(thumbIds[position]);
            return imageView;
        }

        // references to our images
        int[] thumbIds = {
         Resource.Drawable.a16,
         Resource.Drawable.a17,
         Resource.Drawable.a18,
         Resource.Drawable.a21,
         Resource.Drawable.bdk,
         Resource.Drawable.brs,
         Resource.Drawable.bro,
         Resource.Drawable.gyu,
         Resource.Drawable.cel,
         Resource.Drawable.clr,
         Resource.Drawable.fza,
         Resource.Drawable.tgn,
         Resource.Drawable.agh,
         Resource.Drawable.gkn,
         Resource.Drawable.gku,
         Resource.Drawable.bgk,
         Resource.Drawable.blk,
         Resource.Drawable.gtk,
         Resource.Drawable.hit,
         Resource.Drawable.kbu,
         Resource.Drawable.krl,
         Resource.Drawable.buu,
         Resource.Drawable.nap,
         Resource.Drawable.pic,
         Resource.Drawable.ten,
         Resource.Drawable.trk,
         Resource.Drawable.vgn,
         Resource.Drawable.veg,
         Resource.Drawable.bvg,
         Resource.Drawable.vgo,
         Resource.Drawable.yam,
         Resource.Drawable.zam,

    };
    }
}


