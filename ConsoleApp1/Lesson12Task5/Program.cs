namespace Lesson12Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileNetwork myNetwork = new MobileNetwork("Velcome");
            MobilePhone<MobileNetwork> myPhone = new MobilePhone<MobileNetwork>(myNetwork);

            myPhone.DisplayNetworkInfo();
        }
    }
}