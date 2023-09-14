using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TXETT
{
    class Chuhu
    {
        private int _id;
        private string _accounts;
        private string _pass;
        private string _name;
        private string _card;
        private float _money;
        public Chuhu() { }
        public int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public string accounts
        {
            set
            {
                _accounts = value;
            }
            get
            {
                return _accounts;
            }
        }

        public string pass
        {
            set
            {
                _pass = value;
            }
            get
            {
                return _pass;
            }
        }

        public string name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public string card
        {
            set
            {
                _card = value;
            }
            get
            {
                return _card;
            }

        }

        public float money
        {
            set
            {
                _money = value;
            }
            get
            {
                return _money;
            }
        }
    }
}
