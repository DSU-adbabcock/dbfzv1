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
    public class DisplayFrameData : AppCompatActivity
    {

        private ExpandableListViewAdapter mAdapter;
        private ExpandableListView expandableListView;
        private List<string> headers = new List<string>();
        private Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>(); //this is to bind headers and expandable list

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.frame_page);

            string characterName = Intent.GetStringExtra("character") ?? string.Empty; //grab charname from intent

            Character character = new Character(characterName);
            character.InitMoveList(); //this isn't in the constructor because it takes a while and depends on the file existing.

            expandableListView = FindViewById<ExpandableListView>(Resource.Id.expandableListView);

            Setup(character, out mAdapter); //fill out lists

            expandableListView.SetAdapter(mAdapter);
        }

        private void Setup(Character character, out ExpandableListViewAdapter mAdapter)
        {
            List<List <string>> moveData = new List<List<string>>(); //a list of lists. used to store list of data for each move.
            int i = 0;

            foreach(Move move in character.MoveList)
            {
                List<string> tempList = new List<string>(); 
                Type t = move.GetType(); //since each move can be 1 of 3 types we have to do some silly stuff to get tmp to be the correct type in a way the compiler can handle

                if (t.Equals(typeof(SuperMove)))
                {
                    SuperMove tmp = (SuperMove)move;
                    headers.Add(tmp.getFullName());
                    tempList.Add("Damage: " + tmp.Damage);
                    tempList.Add("Minimum Damage: " + tmp.MinDamage);
                    tempList.Add("Guard Type: " + tmp.Guard);
                    tempList.Add("Active: " + tmp.Active);
                    tempList.Add("Recovery: " + tmp.Recovery);
                    tempList.Add("Advantage: " + tmp.Advantage);
                    tempList.Add("Meter: " + tmp.Meter);
                    tempList.Add("Notes: " + tmp.Notes);
                }
                else if(t.Equals(typeof(SpecialMove)))
                {
                    SpecialMove tmp = (SpecialMove)move;
                    headers.Add(tmp.getFullName());
                    tempList.Add("Damage: " + tmp.Damage);
                    tempList.Add("Guard Type: " + tmp.Guard);
                    tempList.Add("Active: " + tmp.Active);
                    tempList.Add("Recovery: " + tmp.Recovery);
                    tempList.Add("Advantage: " + tmp.Advantage);
                    tempList.Add("Meter: " + tmp.Meter);
                    tempList.Add("Notes: " + tmp.Notes);
                }
                else
                {
                    NormalMove tmp = (NormalMove)move;
                    headers.Add(tmp.Name);
                    tempList.Add("Damage: " + tmp.Damage);
                    tempList.Add("Guard Type: " + tmp.Guard);
                    tempList.Add("Active: " + tmp.Active);
                    tempList.Add("Recovery: " + tmp.Recovery);
                    tempList.Add("Advantage: " + tmp.Advantage);
                    tempList.Add("Meter: " + tmp.Meter);
                    tempList.Add("Comments: " + tmp.Notes);
                }
                

                dict.Add(headers[i], tempList); //binds header to expandable list of data
                i++;
            }

            mAdapter = new ExpandableListViewAdapter(this, headers, dict);

        }
    }
}