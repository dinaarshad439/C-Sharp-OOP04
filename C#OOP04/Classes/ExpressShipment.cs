

using C_OOP04.Struct;

namespace C_OOP04.Classes
{
    /// <summary>
    /// Represents an express shipment with an additional extra fee.
    /// </summary>
    internal class ExpressShipment:Shipment
    {
        decimal extraFee;

        #region Property

        public decimal ExtraFee
        {
            get { return extraFee; }
            set { if (value >= 0) extraFee = value; }
        }

        #endregion

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }

        }

        public ExpressShipment(string _trackingCode, string _description, decimal _weight,
            decimal _deliveryFee, DeliveryAddress _destination, decimal _extraFee)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {
            ExtraFee = _extraFee;

        }
        public override decimal CalculateInsurance() 
        {
            return EstimatedCost*0.08m;
        }

        public override void PrintShipment()
        {
            Console.WriteLine("--- Express Shipment ---");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($"Extra Fee: {ExtraFee} EGP");
        }
    }
}
