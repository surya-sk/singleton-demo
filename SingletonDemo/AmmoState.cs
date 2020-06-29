using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
    [System.Serializable]
    public class AmmoState : Settings
    {
        bool pickedUp;

        public void SetPicked(bool picked)
        {
            pickedUp = true;
        }

        public bool GetPicked()
        {
            return pickedUp;
        }

        public string ToString()
        {
            return pickedUp.ToString();
        }
    }
}
