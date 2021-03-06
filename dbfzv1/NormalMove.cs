﻿using System;
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
    public class NormalMove : Move
    {

        public NormalMove()
        {
            name = "Unnamed normal move";
            meter = "0";
        }

        public NormalMove(string n, string d, string g, string s, string act, string r, string adv, string i, string no) //9 inputs
        {
            name = n;
            damage = d;
            guard = g;
            startup = s;
            active = act;
            recovery = r;
            advantage = adv;
            invul = i;
            notes = no;
            meter = "0";
        }


        public override string Name
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

        public override string Damage
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

        public override string Guard
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

        public override string Startup
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

        public override string Active
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

        public override string Recovery
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

        public override string Advantage
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

        public override string Invul
        {
            get
            {
                return invul;
            }
            set
            {
                invul = value;
            }
        }

        public override string Meter
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

        public override string Notes
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
