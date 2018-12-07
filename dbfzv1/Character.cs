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

        public string Name { get; set; }

        public string InitMoveList()
        {
            // string fileName = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData), "Cell.txt");
            // string lines = File.ReadAllLines(fileName);
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(MainActivity)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("dbfzv1.Cell.txt");
            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }

        public void SortMoveList(string sortType)
        {
            //TODO
        }

        
    }
}