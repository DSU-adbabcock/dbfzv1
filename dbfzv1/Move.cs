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
    public class Move
    {
        private string name;
        private string damage;
        private string guard;
        private string active;
        private string recovery;
        private string advantage;
        private string meter;
        private string notes;

        public Move()
        {
            name = "Unnamed move";
        }

        public Move(string n, string d, string g, string act, string r, string adv, string m, string no)
        {
            name = n;
            damage = d;
            guard = g;
            active = act;
            recovery = r;
            advantage = adv;
            meter = m;
            notes = no;
        }
        

        public string Name { get; set; }
        public string Damage { get; set; }
        public string Guard { get; set; }
        public string Active { get; set; }
        public string Recovery { get; set; }
        public string Advantage { get; set; }
        public string Meter { get; set; }
    }
}