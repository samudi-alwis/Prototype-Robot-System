namespace PrototypeRobotSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create original Service Robot
            ServiceRobot serviceRobot = new ServiceRobot
            {
                ModelName = "CareBot-100",
                BatteryCapacity = 8,
                SoftwareVersion = "1.0",
                ServiceTask = "Patient Assistance"
            };

            Console.WriteLine("ORIGINAL ROBOT");
            Console.WriteLine("-------------------------");
            serviceRobot.Display();

            // Clone the Service Robot
            ServiceRobot clonedServiceRobot =
                (ServiceRobot)serviceRobot.Clone();

            // Customize the cloned robot
            clonedServiceRobot.BatteryCapacity = 12;
            clonedServiceRobot.SoftwareVersion = "2.0";

            Console.WriteLine("\nCLONED AND CUSTOMIZED ROBOT");
            Console.WriteLine("-------------------------");
            clonedServiceRobot.Display();

            Console.WriteLine("\n");

            // Create Industrial Robot
            IndustrialRobot industrialRobot = new IndustrialRobot
            {
                ModelName = "FactoryBot-200",
                BatteryCapacity = 10,
                SoftwareVersion = "1.5",
                IndustrialTask = "Welding"
            };

            Console.WriteLine("INDUSTRIAL ROBOT");
            Console.WriteLine("-------------------------");
            industrialRobot.Display();

            // Clone Industrial Robot
            IndustrialRobot clonedIndustrialRobot =
                (IndustrialRobot)industrialRobot.Clone();

            clonedIndustrialRobot.BatteryCapacity = 15;
            clonedIndustrialRobot.SoftwareVersion = "2.0";

            Console.WriteLine("\nCLONED INDUSTRIAL ROBOT");
            Console.WriteLine("-------------------------");
            clonedIndustrialRobot.Display();

            Console.WriteLine("\n");

            // Create Entertainment Robot
            EntertainmentRobot entertainmentRobot = new EntertainmentRobot
            {
                ModelName = "FunBot-300",
                BatteryCapacity = 6,
                SoftwareVersion = "2.0",
                EntertainmentFeature = "Dancing and Interaction"
            };

            Console.WriteLine("ENTERTAINMENT ROBOT");
            Console.WriteLine("-------------------------");
            entertainmentRobot.Display();

            // Clone Entertainment Robot
            EntertainmentRobot clonedEntertainmentRobot =
                (EntertainmentRobot)entertainmentRobot.Clone();

            clonedEntertainmentRobot.BatteryCapacity = 10;
            clonedEntertainmentRobot.SoftwareVersion = "3.0";

            Console.WriteLine("\nCLONED ENTERTAINMENT ROBOT");
            Console.WriteLine("-------------------------");
            clonedEntertainmentRobot.Display();

            Console.ReadLine();
        }
    }
}
