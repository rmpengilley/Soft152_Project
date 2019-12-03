using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_form
{
    public class Property
    {
        //variables
        private string propertyID;
        private string propertyName;
        private string hostID;
        private string hostName;
        private int noOfProperties;
        private string latitudeOfProperty;
        private string longitudeOfProperty;
        private string roomType;
        private double price;
        private string minNoOfNights;
        private string availabilityDays;

        //constructor

        public Property(string publicPropertyID, string publicPropertyName, string publicHostID, string publicHostName, int publicNumProperties, string publicLat,
            string publicLong, string publicRoomType, double publicPrice, string publicMinNumNights, string publicAvailability)
        {
            propertyID = publicPropertyID;
            propertyName = publicPropertyName;
            hostID = publicHostID;
            hostName = publicHostName;
            noOfProperties = publicNumProperties;
            latitudeOfProperty = publicLat;
            longitudeOfProperty = publicLong;
            roomType = publicRoomType;
            price = publicPrice;
            minNoOfNights = publicMinNumNights;
            availabilityDays = publicAvailability;
        }

        //method to add a new property
        public void AddNewProperty(string publicPropertyID, string publicHostID, string publicHostName, int publicNumProperties, string publicLat,
            string publicLong, string publicRoomType, double publicPrice, string publicMinNumNights, string publicAvailability)
        {
            propertyID = publicPropertyID;
            hostID = publicHostID;
            hostName = publicHostName;
            noOfProperties = publicNumProperties;
            latitudeOfProperty = publicLat;
            longitudeOfProperty = publicLong;
            roomType = publicRoomType;
            price = publicPrice;
            minNoOfNights = publicMinNumNights;
            availabilityDays = publicAvailability;
        }

        public void AddNewProp(Property inputTmpProperty)
        {
            Property tmpProperty = inputTmpProperty;
        }

        public string GetPropertyInfo()
        {
            string info = string.Format("Property Id: {0} ,Host ID: {1} ,Host Name: {2} ,Number of Properties: {3} ,Location of Property (lat/Long): {4}:{5} ,Room Type: {6} ," +
                "Property Price {7:$0.00} ,Minimmum number of Nights: {8} ,Availability in year: {9}/365", propertyID, hostID, hostName, noOfProperties, latitudeOfProperty, longitudeOfProperty,
                roomType, price, minNoOfNights, availabilityDays);
            return info;
        }

        //setter
        public void SetPropertyId(string inPropertyID)
        {
            propertyID = inPropertyID;
        }
        public void SetPropertyName(string inPropertyName)
        {
            propertyName = inPropertyName;
        }
        public void SetHostId(string inHostId)
        {
            hostID = inHostId;
        }
        public void SetHostName(string inHostName)
        {
            hostName = inHostName;
        }
        public void SetNumOfProperties(int inNumOfProperties)
        {
            noOfProperties = inNumOfProperties;
        }
        public void SetLattitudeOfProperty(string inLattitudeOfProperty)
        {
            latitudeOfProperty = inLattitudeOfProperty;
        }
        public void SetLongitudeOfProperty(string inLongitudeOfProperty)
        {
            longitudeOfProperty = inLongitudeOfProperty;
        }
        public void SetRoomType(string inRoomType)
        {
            roomType = inRoomType;
        }
        public void SetPrice(double inPrice)
        {
            price = inPrice;
        }
        public void SetminNights(string inMinNights)
        {
            minNoOfNights = inMinNights;
        }
        public void SetAvailability(string inAvailability)
        {
            availabilityDays = inAvailability;
        }

        //getters
        public string GetPropertyId()
        {
            return propertyID;
        }
        public string GetPropertyName()
        {
            return propertyName;
        }
        public string GetHostId()
        {
            return hostID;
        }
        public string GetHostName()
        {
            return hostName;
        }
        public string GetNumOfPropertiesString()
        {
            return noOfProperties.ToString();
        }
        public int GetNumOfProperties()
        {
            return noOfProperties;
        }
        public string GetLattitudeOfProperty()
        {
            return latitudeOfProperty;
        }
        public string GetLongitudeOfProperty()
        {
            return longitudeOfProperty;
        }
        public string GetRoomType()
        {
            return roomType;
        }
        public double GetPrice()
        {
            return price;
        }
        public string GetPriceString()
        {
            return Convert.ToString(price);
        }
        public string GetminNights()
        {
            return minNoOfNights;
        }
        public string GetAvailability()
        {
            return availabilityDays;
        }
    }
}
