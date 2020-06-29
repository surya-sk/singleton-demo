using System;

namespace SingletonDemo
{
    class Program
    {
        static void Main()
        {
            Person personInit = new Person("Surya", "Sashank", new Address("Halifax"));
            Person person = PersonSettings.GetInstance().GetPerson();
            person = person == null ? personInit : person;
            Console.WriteLine(person.ToString());
            AmmoState ammo = PersonSettings.GetInstance().GetAmmo();
            PersonSettings.GetInstance().SaveSettings(person);
            person = PersonSettings.GetInstance().GetPerson();
            Console.WriteLine(person.ToString());
            Console.WriteLine(ammo.ToString());
            person = new Person("123", "YYYY", new Address("ZZZZ"));
            ammo = new AmmoState();
            ammo.SetPicked(true);
            PersonSettings.GetInstance().SaveSettings(ammo);
            PersonSettings.GetInstance().SaveSettings(person);
            person = PersonSettings.GetInstance().GetPerson();
            Console.WriteLine(person.ToString());
            Console.WriteLine(ammo.ToString());
            PersonSettings.GetInstance().WriteSetting();
        }
    }
}
