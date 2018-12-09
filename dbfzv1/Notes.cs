using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

namespace dbfzv1
{
    [Activity(Label = "Notes")]
    public class Notes : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.notes);
            var editText = FindViewById<EditText>(Resource.Id.editText);

            var text = "";

            ISharedPreferences prefs = PreferenceManager.GetDefaultSharedPreferences(this);
            ISharedPreferencesEditor editor = prefs.Edit();
          
            text = prefs.GetString("notes", ""); //using preferences to store notes, 1st param is key, 2nd is default
            
            editText.Text = text; //editText is a modified textView 

            editText.KeyPress += (object sender, Android.Views.View.KeyEventArgs e) => //change preferences on enter press
            {
                e.Handled = false;
                if (e.Event.Action == KeyEventActions.Down && e.KeyCode == Keycode.Enter)
                {
                    editor.PutString("notes", editText.Text);
                    editor.Apply();
                    e.Handled = true;
                }
            };

        }
    }
}