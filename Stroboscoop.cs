using System;
using System.Collections.Generic;
using System.Text;

namespace LichtApp
{
    class Stroboscoop : Lamp
    {
        private int _frequentie;

        public Stroboscoop(int id, string kleur, string status, int freq)
            :base(id, kleur, status)
        {
            _frequentie = freq;
        }

        public override void LampSwitch()
        {
            if (base.GetStatus() == "uit")
            {
                base.SetStatus("knipperen");
            }
            else
            {
                base.SetStatus("uit");
            }
        }
    }


}
