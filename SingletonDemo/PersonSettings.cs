using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SingletonDemo
{
     public sealed class PersonSettings
    {
        private static PersonSettings instace = new PersonSettings();
        string path1 = "C:\\Users\\surya\\OneDrive\\Projects\\SingletonDemo\\SingletonDemo\\data1.save";
        string path2 = "C:\\Users\\surya\\OneDrive\\Projects\\SingletonDemo\\SingletonDemo\\data2.save";
        private Person person = null;
        private AmmoState ammo = new AmmoState();

        private PersonSettings()
        {

        }

        public static PersonSettings GetInstance()
        {
            return instace;
        }

        public void WriteSetting()
        {
            using (FileStream fileStream = File.Open(path1, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, this.person);
            }

            using (FileStream fileStream = File.Open(path2, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, this.ammo);
            }
        }

        public void SaveSettings(Settings settings)
        {
            if(settings.GetType()==typeof(Person))
            {
                this.person = (Person)settings;
            }
            if (settings.GetType() == typeof(AmmoState))
            {
                this.ammo = (AmmoState)settings;
            }


        }

        public Person GetPerson()
        {
            if(this.person== null)
            {
                this.person = (Person)GetSettings(path1);
            }
            return person;
        }

        private Settings GetSettings(string path)
        {
            Settings setting = null;
            if (File.Exists(path1))
            {
                using (FileStream fileStream = File.Open(path1, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    setting = (Settings)binaryFormatter.Deserialize(fileStream);
                }
            }
            return setting;
        }

        public AmmoState GetAmmo()
        {
            if (this.ammo == null)
            {
                this.ammo = (AmmoState)GetSettings(path2);
            }
            return ammo;
        }



    }
}
