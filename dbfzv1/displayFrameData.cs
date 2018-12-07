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

namespace dbfzv1
{
    [Activity(Label = "Activity1")]
    public class displayFrameData : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            string characterName = Intent.GetStringExtra("character") ?? string.Empty;
            Character character = new Character(characterName);
            string text = character.InitMoveList();
            string adv = character.MoveList[1].Advantage;
            Toast.MakeText(this, adv, ToastLength.Long).Show();
            // Create your application here
        }
    }
}