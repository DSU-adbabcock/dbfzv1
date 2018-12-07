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
        private string startup;
        private string active;
        private string recovery;
        private string advantage;
        private string meter;
        private string notes;

        public Move()
        {
            name = "Unnamed move";
        }

        public Move(string n, string d, string g, string s, string act, string r, string adv, string m, string no)
        {
            name = n;
            damage = d;
            guard = g;
            startup = s;
            active = act;
            recovery = r;
            advantage = adv;
            meter = m;
            notes = no;
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

        public string Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }

        public string Guard
        {
            get
            {
                return guard;
            }
            set
            {
                guard = value;
            }
        }

        public string Startup
        {
            get
            {
                return startup;
            }
            set
            {
                startup = value;
            }
        }

        public string Active
        {
            get
            {
                return active;
            }
            set
            {
                active = value;
            }
        }

        public string Recovery
        {
            get
            {
                return recovery;
            }
            set
            {
                recovery = value;
            }
        }

        public string Advantage
        {
            get
            {
                return advantage;
            }
            set
            {
                advantage = value;
            }
        }

        public string Meter
        {
            get
            {
                return meter;
            }
            set
            {
                meter = value;
            }
        }

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
            }
        }
    }
}