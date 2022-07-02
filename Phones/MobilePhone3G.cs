using PhonesDirectum.Stations;

namespace PhonesDirectum.Phones
{
    public class MobilePhone3G : Phone
    {
        public MobilePhone3G(string imei, string sim, List<Contact> contacts)
        {
            Imei = imei;
            Sim = sim;
            Contacts = contacts;
        }

        public override IBaseStation ConnectToBaseStation()
        {
            return new BaseStation3G();
        }
    }
}
