

using C_OOP04.Struct;

namespace C_OOP04.Classes
{
    /// <summary>
    /// Represents an international shipment with a destination country and customs fee.
    /// </summary>
    internal class InternationalShipment:Shipment
    {
        decimal customsFee;
        string destinationCountry;


        #region Properties

        public string DestinationCountry
        {
            get { return destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }

        public decimal CustomsFee
        {
            get { return customsFee; }
            set
            {
                if (value >= 0) customsFee = value;
            }
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }

        }

        #endregion

        #region Constructor

        public InternationalShipment(string _trackingCode, string _description,
            decimal _weight, decimal _deliveryFee, DeliveryAddress _destination, string _destinationCountry, decimal _customFee,string _status)
            : base(_trackingCode, _description, _weight, _deliveryFee, _destination,_status)
        {
            DestinationCountry = _destinationCountry;
            CustomsFee = _customFee;
        }

        #endregion

        #region Methods
        public override decimal CalculateInsurance()
        {
            return EstimatedCost*0.12m;
        }
        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine($"Cutom report generated fo{DestinationCountry}");
        }
        public override void PrintShipment()
        {
            Console.WriteLine("--- International Shipment ---");
            Console.WriteLine("International Shipment\n");
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP\n");
        }
    }


        #endregion
}


