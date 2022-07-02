using PhonesDirectum.Phones;

namespace PhonesDirectum.Stations
{
    public class BaseStation : IBaseStation
    {
        public BaseStation()
        {
            Console.WriteLine("Connected to base station");
        }
        public void RegPhone(Phone phone)
        {
            Type Type = phone.GetType();
            string Imei = phone.Imei;
            string Sim = phone.Sim;
            Console.WriteLine("Phone type: {0}, IMEI: {1}, SIM: {2} is registered.", Type.ToString(), Imei, Sim);
        }
    }
}
