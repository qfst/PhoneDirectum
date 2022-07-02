namespace PhonesDirectum.Phones
{
    public class Contact
    {
        public string FullName { get; set; }
        public string Number { get; set; }

        public Contact(string fullName, string number)
        {
            FullName = fullName;
            Number = number;
        }
    }
}