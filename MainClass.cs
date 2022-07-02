using PhonesDirectum.Phones;
using PhonesDirectum.Stations;

namespace PhonesDirectum
{
    public class MainClass
    {
        public static void Main()
        {
            Phone mobilePhone3G = new MobilePhone3G("449125-54-658876-9", "8(909)802-68-42", GetContacts());

            Phone mobilePhone = new MobilePhone("447402-51-543765-0", "8(975)899-05-78", GetContacts());

            UsePhone(mobilePhone);

            UsePhone(mobilePhone3G);
        }

        public static void UsePhone(Phone phone)
        {
            IBaseStation baseStation = phone.ConnectToBaseStation();
            baseStation.RegPhone(phone);
            phone.Call(phone.Contacts[new Random().Next(0, 2)].Number);
        }

        public static List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            Contact[] data = { new Contact("Шишкин Пров Тестович", "8(953)099-12-47"), new Contact("Березовский Варлам Тестович", "8(925)671-67-85") };
            contacts.AddRange(data);
            return contacts;
        }
    }
}
