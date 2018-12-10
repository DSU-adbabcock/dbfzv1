using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace dbfzv1
{
    public class Character
    {
        private string name;
        private List<Move> moveList = new List<Move>();

        public Character()
        {
            name = "Unnamed character";
        }

        public Character(string n)
        {
            name = n;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public List<Move> MoveList
        {
            get
            {
                return moveList;
            }
        }


        public void InitMoveList()
        {
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainActivity)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("dbfzv1." + name + ".txt"); //get embedded char file
            string text = "";
            using (var reader = new System.IO.StreamReader(stream)) //read in normals
            {
                name = reader.ReadLine();
                text = reader.ReadLine();
                while(text != "SPECIAL")
                {
                    System.Diagnostics.Debug.WriteLine(text);
                    string[] data = text.Split(" /"); //name, damage, guard, startup, active, recovery, advantage, invuln, notes
                    NormalMove move = new NormalMove(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8]);
                    moveList.Add(move);
                    text = reader.ReadLine();
                }
                text = reader.ReadLine();
                while (text != "SUPER") //specials
                {
                    //System.Diagnostics.Debug.WriteLine(text);
                    string[] data = text.Split(" /"); //name, input, meter, damage, guard, startup, active, recovery, advantage, invuln, notes
                    foreach(string stuff in data)
                    {
                        System.Diagnostics.Debug.WriteLine(stuff);
                    }
                    SpecialMove move = new SpecialMove(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10]);
                    moveList.Add(move);
                    text = reader.ReadLine();
                }
                text = reader.ReadLine();
                while(text != "END") //supers. I could have done reader.RealUntilEnd (or whatever that func is called) but this helped error check
                {
                    System.Diagnostics.Debug.WriteLine(text);
                    string[] data = text.Split(" /"); //name, input, meter, damage, minDamage, guard, startup, active, recovery, advantage, invuln, notes
                    SuperMove move = new SuperMove(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10], data[11]);
                    moveList.Add(move);
                    text = reader.ReadLine();
                }
            }

        }

        public void SortMoveList(string sortType)
        {
            //TODO
        }

        
    }
}