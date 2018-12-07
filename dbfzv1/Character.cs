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


        public string InitMoveList()
        {
            // string fileName = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Cell.txt");
            // string lines = File.ReadAllLines(fileName);
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainActivity)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("dbfzv1." + name + ".txt");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                name = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    text = reader.ReadLine();
                    System.Diagnostics.Debug.WriteLine(text);
                    string[] data = text.Split(" /"); //name, damage, guard, active, recovery, advantage, meter, notes
                    Move move = new Move(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8]);
                    moveList.Add(move);
                }
            }
            return text;
        }

        public void SortMoveList(string sortType)
        {
            //TODO
        }

        
    }
}