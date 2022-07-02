using PhonesDirectum.Phones;

namespace PhonesDirectum.Stations
{
    public class BaseStation3G : IBaseStation
    {
        public BaseStation3G()
        {
            Console.WriteLine("Connected to base station 3G");
        }
        public void RegPhone(Phone phone)
        {
            Type Type = phone.GetType();
            string Imei = phone.Imei;
            string Sim = phone.Sim;
            Console.WriteLine("Special register for 3G phone. Phone type: {0}, IMEI: {1}, SIM: {2} is registered.", Type.ToString(), Imei, Sim);
        }
    }
}
