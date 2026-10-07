using C_OOP04.Classes;
using C_OOP04.Interfaces;
using C_OOP04.Struct;

namespace C_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions 

            #region Q1 Abstraction

            /*
             *  (a) Abstraction is hiding Complex implementation and showing only essential features
             */

            /*
             *  (b) becaue it reduce complexity ,Improve maintainabilty, enhance security and promote flexibilty and reusabilty
             */

            #endregion

            #region Q2 abract class vs Interface

            /*
             *  (a) abstract class:
             *      1- have fields, property, Methods
             *      2- have constructors
             *      3- class can extend only one abstract class.
             *      
             *      
             *      interface:
             *      1- have static constant and method signature
             *      2- have no constructors
             *      3- class can implement multiple interfaces.
             *      
             */

            /*
             *  (b) to implement multiple inheritance and to avoid coupling.
             */

            /*
             *  (c) no you cannot make multiple inheritance on abstract class as it can extend only one abstract class
             *   yes class can implement multiple interfaces.
             */
            #endregion

            #endregion

            #region Practical Questions

            
            DeliveryCenter center = new DeliveryCenter("Delivery Center");
            
            //a
            Console.WriteLine("====================================================");
            Console.WriteLine("Enter the standard shipment");
            ReadShipmentData(
                out string? trackingCode,
                out string? description,
                out decimal weight,
                out decimal deliveryFee,
                out DeliveryAddress destination
            );

            StandardShipment standard = new StandardShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                "Ready."
            );


            //b
            Console.WriteLine("======================================================");
            Console.WriteLine("Enter the express shipment");
            ReadShipmentData(
                 out trackingCode,
                 out description,
                 out weight,
                 out deliveryFee,
                 out destination
);

            Console.WriteLine("Enter Extra Fee:");
            decimal extraFee = decimal.Parse(Console.ReadLine());

            ExpressShipment express = new ExpressShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                extraFee,
                "Out for Delivery."

            );



            //c
            Console.WriteLine("====================================================");

            Console.WriteLine("Enter the international shipment");
            ReadShipmentData(
              out trackingCode,
              out description,
              out weight,
              out deliveryFee,
              out destination
            );

            Console.WriteLine("Enter Destination Country:");
            string? destinationCountry = Console.ReadLine();

            Console.WriteLine("Enter Customs Fee:");
            decimal customsFee = decimal.Parse(Console.ReadLine());

            InternationalShipment international = new InternationalShipment(
                trackingCode,
                description,
                weight,
                deliveryFee,
                destination,
                destinationCountry,
                customsFee,
                "has been Delivered."
            );

            //d
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);


            //e
            center.PrintAllShipments();

            //f
            Console.WriteLine("====================================================");

            center.PrintTrackingStatuses();

            //g
            Console.WriteLine("====================================================");

            center.PrintCalculatedInsurance();

            //h
            Console.WriteLine("====================================================");

            ITrackable[] track=new ITrackable[] 
            {
                  standard,
                  express,
                  international

            };

            foreach(var tracks in track)
            {
                Console.WriteLine("Tracking status: ");
                Console.WriteLine(tracks.GetTrackingStatus());
            }


            //i
            Console.WriteLine("====================================================");

            IInsurable[] insurance = new IInsurable[]
            {
                standard,
                express,
               international
            };

            foreach (var insure in insurance)
            {
                Console.WriteLine("Insurance: ");
                Console.WriteLine($"Insurance: {insure.CalculateInsurance():0.00} EGP");
            }

            Console.WriteLine("====================================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");


            #endregion
        }

        public static void ReadShipmentData(
           out string? trackingCode,
           out string? description,
           out decimal weight,
           out decimal deliveryFee,
           out DeliveryAddress destination)
        {
            Console.WriteLine("Enter tracking code:");
            trackingCode = Console.ReadLine();

            Console.WriteLine("Enter description:");
            description = Console.ReadLine();

            Console.WriteLine("Enter weight:");
            weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter delivery fee:");
            deliveryFee = decimal.Parse(Console.ReadLine());



            Console.WriteLine("Enter City:");
            string? city = Console.ReadLine();

            Console.WriteLine("Enter street:");
            string? street = Console.ReadLine();

            bool flag = false;
            int buildingNumber;

            do
            {
                Console.WriteLine("Enter building number:");
                flag = int.TryParse(Console.ReadLine(), out buildingNumber);

            } while (!flag);

            destination = new DeliveryAddress(city, street, buildingNumber);
        }
    }
}
