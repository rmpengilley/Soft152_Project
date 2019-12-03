using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_form
{
    public class Neighbourhood
    {
        private string neighbourhoodName;
        private int propertiesInNeighbourhood;
        Property[] localProperties;

        //constructors
        public Neighbourhood()
        {

        }
        public Neighbourhood(string publicNeighbourhoodName, int publicPropertiesInNeighbourhood)
        {
            neighbourhoodName = publicNeighbourhoodName;
            propertiesInNeighbourhood = publicPropertiesInNeighbourhood;
        }
        public Neighbourhood(string publicNeighbourhoodName, int publicPropertiesInNeighbourhood, Property[] allPropertyArray)
        {
            neighbourhoodName = publicNeighbourhoodName;
            propertiesInNeighbourhood = publicPropertiesInNeighbourhood;
            localProperties = allPropertyArray;
        }

        //Add a new neighbourhood
        public void AddNewNeighbourhood(string publicNeighbourhoodName, int publicPropertiesInNeighbourhood, Property[] allPropertyArray)
        {
            neighbourhoodName = publicNeighbourhoodName;
            propertiesInNeighbourhood = publicPropertiesInNeighbourhood;
            localProperties = allPropertyArray;

        }
        public void AddNewNhood(Neighbourhood inputTmpNeighbourhood)
        {
            Neighbourhood tmpNeighbourhood = inputTmpNeighbourhood;
        }

        //Getters
        public string GetNeighbourhoodInfo()
        {
            string info = string.Format("Neighbourhood: {0} - Contains {1} property", neighbourhoodName, Convert.ToInt32(propertiesInNeighbourhood));
            return info;
        }
        public string GetNeighbourhoodName()
        {
            return neighbourhoodName;
        }
        public int GetPropertiesInNeighbourhood()
        {
            return propertiesInNeighbourhood;
        }


        //Setters
        public void SetNeighbourhoodName(string inNeighbourhoodName)
        {
            neighbourhoodName = inNeighbourhoodName;
        }

        public void SetPropertiesInNeighberhood(int inPropertiesInNeighbourhood)
        {
            propertiesInNeighbourhood = inPropertiesInNeighbourhood;
        }

        //property getters


        public string GetPropertyInfo(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetPropertyInfo();
        }
        public string GetPropertyId(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetPropertyId();
        }
        public string GetPropertyName(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetPropertyName();
        }
        public string GetHostId(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetHostId();
        }
        public string GetHostName(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetHostName();
        }
        public string GetNumOfPropertiesString(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetNumOfProperties().ToString();
        }
        public int GetNumOfProperties(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetNumOfProperties();
        }
        public string GetLattitudeOfProperty(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetLattitudeOfProperty();
        }
        public string GetLongitudeOfProperty(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetLongitudeOfProperty();
        }
        public string GetRoomType(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetRoomType();
        }
        public double GetPrice(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetPrice();
        }
        public string GetPriceString(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetPrice().ToString();
        }
        public string GetminNights(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetminNights();
        }
        public string GetAvailability(int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            return localProperties[selectedProperty].GetAvailability();
        }

        public Property[] GetPropertyArray()
        {
            return localProperties;
        }

        //property Setters

        public void AddNewProp(Property inputTmpProperty)
        {
            int currentPropertySize = localProperties.Length; //get array size
            Array.Resize(ref localProperties, currentPropertySize + 1); //make an array space
            localProperties[currentPropertySize] = inputTmpProperty;
        }
        public void SetNewProperty(int inCurrentProperty, Property inputTmpProperty)
        {
            localProperties[inCurrentProperty] = inputTmpProperty;
        }
        
        public void SetPropertyArray(Property[] inLocalProperties)
        {
            localProperties = inLocalProperties;
        }

        public void SetPropertyId(int inCurrentProperty, string inPropertyID)
        {
            localProperties[inCurrentProperty].SetPropertyId(inPropertyID);
        }
        public void SetPropertyName(int inCurrentProperty, string inPropertyName)
        {
            localProperties[inCurrentProperty].SetPropertyName(inPropertyName);
        }
        public void SetHostId(int inCurrentProperty, string inHostId)
        {
            localProperties[inCurrentProperty].SetHostId(inHostId);
        }
        public void SetHostName(int inCurrentProperty, string inHostName)
        {
            localProperties[inCurrentProperty].SetHostName(inHostName);
        }
        public void SetNumOfProperties(int inCurrentProperty, int inNumOfProperties)
        {
            localProperties[inCurrentProperty].SetNumOfProperties(inNumOfProperties);
        }
        public void SetLattitudeOfProperty(int inCurrentProperty, string inLattitudeOfProperty)
        {
            localProperties[inCurrentProperty].SetLattitudeOfProperty(inLattitudeOfProperty);
        }
        public void SetLongitudeOfProperty(int inCurrentProperty, string inLongitudeOfProperty)
        {
            localProperties[inCurrentProperty].SetLongitudeOfProperty(inLongitudeOfProperty);
        }
        public void SetRoomType(int inCurrentProperty, string inRoomType)
        {
            localProperties[inCurrentProperty].SetRoomType(inRoomType);
        }
        public void SetPrice(int inCurrentProperty, double inPrice)
        {
            localProperties[inCurrentProperty].SetPrice(inPrice);
        }
        public void SetminNights(int inCurrentProperty, string inMinNights)
        {
            localProperties[inCurrentProperty].SetminNights(inMinNights);
        }
        public void SetAvailability(int inCurrentProperty, string inAvailability)
        {
            localProperties[inCurrentProperty].SetAvailability(inAvailability);
        }
    }


}
