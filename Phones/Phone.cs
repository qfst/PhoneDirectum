using PhonesDirectum.Stations;

namespace PhonesDirectum.Phones
{
    public abstract class Phone
    {
        public string Imei { get; init; }
        public string Sim { get; set; }
        public List<Contact> Contacts { get; set; }

        public abstract IBaseStation ConnectToBaseStation();

        public void Call(string number)
        {
            Console.WriteLine("Call to number: {0}...", number);
        }
        public void Call(Contact contact)
        {
            Call(contact.Number);
        }
    }
}