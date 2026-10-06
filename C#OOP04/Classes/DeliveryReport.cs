

using C_OOP04.Interfaces;

namespace C_OOP04.Classes
{
   internal class DeliveryReport
   {
       public void PrintShipment(ITrackable shipment)
       {
                Console.WriteLine(shipment.GetTrackingStatus());
       }

       public void PrintInsurance(IInsurable shipment)
       {
           Console.WriteLine($"Insurance: {shipment.CalculateInsurance():0.00} EGP");
       }
   }
}

