namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initiates main logic
            VendingManager manager = new VendingManager();
            manager.RunVendingMachine();
        }
    }
}