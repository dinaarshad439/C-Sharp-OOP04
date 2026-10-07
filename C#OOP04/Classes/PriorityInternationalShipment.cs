

using C_OOP04.Struct;

namespace C_OOP04.Classes
{
    /// <summary>
    /// Represents a priority international shipment.
    /// Inherits international shipment information and behavior
    /// and provides a sealed implementation of GenerateCustomsReport.
    /// </summary>
    internal class PriorityInternationalShipment: InternationalShipment
    {
        public PriorityInternationalShipment(string _trackingCode, string _description,
           decimal _weight, decimal _deliveryFee, DeliveryAddress _destination, string _destinationCountry, decimal _customFee,string _status)
           : base(_trackingCode, _description, _weight, _deliveryFee, _destination, _destinationCountry, _customFee,_status) { }

        public override sealed void GenerateCustomsReport()
        {
            Console.WriteLine($"Cutom report generated fo{DestinationCountry} with fee: {CustomsFee}");
        }
    }
}
