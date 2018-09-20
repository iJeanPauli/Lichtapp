using System;
using System.Collections.Generic;
using System.Text;

namespace LichtApp
{
    class Lamp
    {
        private int _id;
        private string _kleur;
        private string _status;

        public Lamp(int id, string kleur, string status)
        {
            _id = id;
            _kleur = kleur;
            _status = status;
        }

        public int GetID()
        {
            return _id;
        }

        public string GetKleur()
        {
            return _kleur;
        }

        public string GetStatus()
        {
            return _status;
        }

        public void LampSwitch()
        {
            if (_status == "uit")
            {
                _status = "aan";
            }
            else
            {
                _status = "uit";
            }
        }
        }
}
