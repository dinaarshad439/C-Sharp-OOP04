

namespace C_OOP04.Classes
{
    /// <summary>
    /// Represents a delivery center that stores and manages shipments.
    /// </summary>
    internal class DeliveryCenter
    {
        #region fields
        private Shipment?[] shipments;
        #endregion

        #region Property
        public string CenterName { get; set; }

        #endregion


        #region Constructor
        public DeliveryCenter(string _centerName)
        {
            shipments = new Shipment[20];
            CenterName = _centerName;
        }
        #endregion 

        #region Indexers

        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < shipments.Length)
                    return shipments[index];

                return default;



            }

            set
            {
                if (index >= 0 && index < shipments.Length) shipments[index] = value;
            }
        }

        public Shipment this[string index]
        {

            get
            {
                if (!string.IsNullOrWhiteSpace(index))
                    for (int i = 0; i < shipments.Length; i++)
                    {
                        if (shipments[i] != null && shipments[i].TrackingCode == index)
                            return shipments[i];
                    }
                return default;
            }
        }
        #endregion

        #region Methods

        /// <summary> 
        /// Adds a shipment to the first available position in the delivery center. 
        /// </summary> 
        /// <param name="shipment">The shipment to be added.</param> 
        /// <returns>
        /// true if the shipment was added successfully;
        /// otherwise, false if there is no available position.
        /// </returns>
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    Console.WriteLine("Shipment added successfully");
                    return true;

                }
            }

            return false;
        }

        /// <summary>
        /// Removes a shipment from the delivery center using its tracking code.
        /// </summary>
        /// <param name="trackingCode">The tracking code of the shipment to remove.</param>
        /// <returns>
        /// true if the shipment was found and removed; 
        /// otherwise, false.
        /// </returns>

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Prints all stored shipments in the delivery center.
        /// </summary>
        public void PrintAllShipments()
        {
            foreach (var shipment in shipments)
            {
                if (shipment != null)
                {
                    shipment.PrintShipment();
                    Console.WriteLine("--------------------------------------");
                }
            }
        }


        #endregion
    }
}

