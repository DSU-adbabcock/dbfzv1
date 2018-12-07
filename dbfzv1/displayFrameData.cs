using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace dbfzv1
{ 
    [Activity(Label = "Frame Data")]
    public class displayFrameData : AppCompatActivity
    {

        ExpandableListViewAdapter mAdapter;
        ExpandableListView expandableListView;
        List<string> headers = new List<string>();
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.frame_page);

            //ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleExpandableListItem1, countries);

           // ListView.TextFilterEnabled = true;


            string characterName = Intent.GetStringExtra("character") ?? string.Empty;
            Character character = new Character(characterName);
            string text = character.InitMoveList();
            string adv = character.MoveList[1].Advantage;
            Toast.MakeText(this, adv, ToastLength.Long).Show();

           // var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            //SetSupportActionBar(toolbar);
            //SupportActionBar.Title = "Expandable ListView";
            expandableListView = FindViewById<ExpandableListView>(Resource.Id.expandableListView);

            testSetup(character, out mAdapter);

            expandableListView.SetAdapter(mAdapter);
            // Create your application here
        }

        private void testSetup(Character character, out ExpandableListViewAdapter mAdapter)
        {
            List<List <string>> moveData = new List<List<string>>(); //a list of lists. used to store list of data for each move.
            int i = 0;

            foreach(Move move in character.MoveList)
            {
                headers.Add(move.Name);
                List<string> tempList = new List<string>();

                tempList.Add(move.Damage);
                tempList.Add(move.Guard);
                tempList.Add(move.Active);
                tempList.Add(move.Recovery);
                tempList.Add(move.Advantage);
                tempList.Add(move.Meter);
                tempList.Add(move.Notes);
                dict.Add(headers[i], tempList);
                i++;
            }
            
        //  for(int i = 0; i <= headers.Count(); i++)
          //  {
            //    dict.Add(headers[i], moveData[i]);
            //}

           // dict.Add(headers[0], listA);
            //dict.Add(headers[1], listB);

            mAdapter = new ExpandableListViewAdapter(this, headers, dict);

        }
    }
}