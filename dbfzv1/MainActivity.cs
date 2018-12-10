using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections;
using System.Collections.Generic;
using dbfzv1.Adapter;
using Android.Content;
using Android.Views;

namespace dbfzv1
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        string[] characters = {"Notepad", "Android 16", "Android 17", "Android 18", "Android 21", "Bardock", "Beerus", "Broly", "Ginyu", "Cell", "Cooler", "Frieza", "Teen Gohan", "Adult Gohan", "Base Goku",
                                "SSJ Goku", "Goku Blue", "Goku Black", "Gotenks", "Hit", "Kid Buu", "Krillin", "Majin Buu", "Nappa", "Piccolo", "Tien", "Trunks", "Base Vegeta", "SSJ Vegeta",
                                "Vegeta Blue", "Vegito", "Yamcha", "Zamasu"}; //notepad isn't a character but it was the easiest way to do this, fight me


        
        ArrayList charlist;
        GridView gridView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            gridView = FindViewById<GridView>(Resource.Id.gridView);
            getCharList();
            gridView.Adapter = new ImageAdapter(this);

            gridView.ItemClick += gridView_ItemClick;


        }

        //FILL DATA
        private void getCharList()
        {
            charlist = new ArrayList();
            foreach (var item in characters)
                charlist.Add(item);

        }

        void gridView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent charIntent;
            if (e.Position == 0) //open notes
            {
                charIntent = new Intent(this, typeof(Notes));
                StartActivity(charIntent);
            }
            else 
            {
                charIntent = new Intent(this, typeof(DisplayFrameData));
                charIntent.PutExtra("character", characters[e.Position]); //pass charname to displayFrameData activity to choose which char to display for
                StartActivity(charIntent);
            }
        }
    }

}