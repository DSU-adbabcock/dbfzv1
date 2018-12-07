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
    abstract public class Move
    {
        protected string name;
        protected string damage;
        protected string guard;
        protected string startup;
        protected string active;
        protected string recovery;
        protected string advantage;
        protected string invul;
        protected string meter;
        protected string notes;

        public abstract string Name
        {
            get; set;
        }

        public abstract string Damage
        {
            get; set;
        }

        public abstract string Guard
        {
            get; set;
        }

        public abstract string Startup
        {
            get; set;
        }

        public abstract string Active
        {
            get; set;
        }

        public abstract string Recovery
        {
            get; set;
        }

        public abstract string Advantage
        {
            get; set;
        }

        public abstract string Invul
        {
            get; set;
        }

        public abstract string Meter
        {
            get; set;
        }

        public abstract string Notes
        {
            get; set;
        }
    }
}