using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LichtApp
{
    class LichtKnop
    {
        private int _id;
        private string _status;
        public List<Lamp> LampenSet = new List<Lamp>();

        public LichtKnop(int id, string status)
        {
            _id = id;
            _status = status;
        }

        public void VoegLampToe(Lamp lamp)
        {
            LampenSet.Add(lamp);
        }

        public int GetID()
        {
            return _id;
        }

        public string GetStatus()
        {
            return _status;
        }

        public void LichtKnopSwitch()
        {
            if (_status == "uit")
            {
                _status = "aan";
            }
            else
            {
                _status = "uit";
            }

            for (int i = 0; i < LampenSet.Count(); i++)
            {
                LampenSet[i].LampSwitch();
            }
        }

    }
}
