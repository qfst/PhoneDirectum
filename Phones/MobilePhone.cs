using PhonesDirectum.Stations;

namespace PhonesDirectum.Phones
{
    public class MobilePhone : Phone
    {
        public MobilePhone(string imei, string sim, List<Contact> contacts)
        {
            Imei = imei;
            Sim = sim;
            Contacts = contacts;
        }
        public override IBaseStation ConnectToBaseStation()
        {
            return new BaseStation();
        }
    }
}