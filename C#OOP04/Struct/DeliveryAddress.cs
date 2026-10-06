

namespace C_OOP04.Struct
{
    /// <summary>
    /// Represents a delivery address with city, street, and building number.
    /// </summary>
    internal class DeliveryAddress
    {
        #region fields
        public string City;
        public string Street;
        public int BuildingNumber;

        #endregion

        #region Constructor
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion

        #region Method
        /// <summary>
        /// method gets the full address 
        /// </summary>
        /// <returns> full address as a single string </returns>
        public string GetFullAddress()
        {
            return $"{City}, {Street}, {BuildingNumber}";
        }

        #endregion
    }
}
