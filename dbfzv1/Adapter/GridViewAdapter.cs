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
    class GridViewAdapter : BaseAdapter
    {

        List<string> lstSource;
        Context context;

        public GridViewAdapter(List<string> lstSource,Context context)
        {
            this.lstSource = lstSource;
            this.context = context;
        }
        public override int Count
        {
            get
            {
                return lstSource.Count;
            }
        }

        public ComplexUnitType Sp { get; private set; }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Button button = null;
            if (convertView == null)
            {
                button = new Button(context);
                button.LayoutParameters = new GridView.LayoutParams(WindowManagerLayoutParams.WrapContent, WindowManagerLayoutParams.WrapContent);
                button.SetPadding(8, 8, 8, 8);
                button.SetBackgroundColor(Color.DarkGray);
                button.SetTextColor(Color.Yellow);
                button.SetTextSize(Sp, 30);
                button.Text = lstSource[position]; //wut da hell
                button.Click += delegate
                {
                    Toast.MakeText(context, "" + button.Text, ToastLength.Short).Show();
                };
            }
            else
                button = (Button)convertView;
            return button;

        }
    }
}