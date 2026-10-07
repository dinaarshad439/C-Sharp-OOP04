

using C_OOP04.Struct;

namespace C_OOP04.Classes
{
    /// <summary>
    /// Represents a standard shipment.
    /// </summary>
    internal class StandardShipment:Shipment
    {
        #region Constructor

        public StandardShipment(string _trackingCode, string _description, decimal _weight, decimal _deliveryFee, DeliveryAddress _destination,string _status)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination,_status) { }

        #endregion

        public override decimal EstimatedCost => DeliveryFee + (Weight * 5);

        public override decimal CalculateInsurance()
        {
            return EstimatedCost*0.05m ; 
        }

        public override void PrintShipment()
        {
            Console.WriteLine("--- Standard Shipment ---");
             Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code  : {TrackingCode}");
            Console.WriteLine($"Description    : {Description}");
            Console.WriteLine($"Estimated Cost : {EstimatedCost} EGP\n");
          
            

        }
    }
}
