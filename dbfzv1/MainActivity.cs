using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections;
using System.Collections.Generic;
using dbfzv1.Adapter;

namespace dbfzv1
{
    [Activity(Label = "@string/app_name", Theme = "@style/Theme.AppCompat.Light.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        string[] characters = {"Android 16", "Android 17", "Android 18", "Android 21", "Bardock", "Beerus", "Broly", "Ginyu", "Cell", "Cooler", "Frieza", "Teen Gohan", "Adult Gohan", "Base Goku",
                                "SSJ Goku", "Goku Blue", "Goku Black", "Gotenks", "Hit", "Kid Buu", "Krillin", "Majin Buu", "Nappa", "Piccolo", "Tien", "Trunks", "Base Vegeta", "SSJ Vegeta",
                                "Vegeta Blue", "Vegito", "Yamcha", "Zamasu"};

        List<string> lstResult = new List <string>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            GridView gridView = FindViewById<GridView>(Resource.Id.gridView);
            GridViewAdapter gridViewAdapter = new GridViewAdapter(lstResult, this);
            gridView.Adapter = gridViewAdapter;
            SetupList();
        }

        private void SetupList()
        {
            foreach (var item in characters)
                lstResult.Add(item);
        }
    }
}