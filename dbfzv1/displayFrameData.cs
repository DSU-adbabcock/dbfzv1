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
    [Activity(Label = "Activity1")]
    public class displayFrameData : AppCompatActivity
    {

        ExpandableListViewAdapter mAdapter;
        ExpandableListView expandableListView;
        List<string> group = new List<string>();
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
            List<string> listA = new List<string>();
            List<string> listB = new List<string>();

            listA.Add("A-1");
            listA.Add("B-1");

            listB.Add("C-1");
            listB.Add("C-2");

            group.Add("Group A");
            group.Add("Group B");

            dict.Add(group[0], listA);
            dict.Add(group[1], listB);

            mAdapter = new ExpandableListViewAdapter(this, group, dict);

        }
    }
}