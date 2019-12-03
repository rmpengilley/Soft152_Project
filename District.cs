using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_form
{
    public class District
    {
        private string districtName;
        private int neighbourhoodsInDistrict;
        private Neighbourhood[] neighbourhoodArray;

        //constructor
        public District()
        {

        }
        public District(string publicDistrictName, int publicNeighbourhoodsInDistrict)
        {
            districtName = publicDistrictName;
            neighbourhoodsInDistrict = publicNeighbourhoodsInDistrict;
        }
        public District(string publicDistrictName, int publicNeighbourhoodsInDistrict, Neighbourhood[] allNneighbourhoodArray)
        {
            districtName = publicDistrictName;
            neighbourhoodsInDistrict = publicNeighbourhoodsInDistrict;
            neighbourhoodArray = allNneighbourhoodArray;
        }
        public void addNewDistrict(string publicDistrictName, int publicNeighbourhoodsInDistrict)
        {
            districtName = publicDistrictName;
            neighbourhoodsInDistrict = publicNeighbourhoodsInDistrict;
        }
        public string GetDistrictInfo()
        {
            string info = string.Format("District Name: {0} - Neighbourhood(s) in the District: {1}", districtName, neighbourhoodsInDistrict.ToString());
            return info;
        }

        // District Getter
        public string GetDistrictName()
        {
            return districtName;
        }
        public int GetNeighbourhoodsInDistrict()
        {
            return neighbourhoodsInDistrict;
        }
        public string GetNeighbourhoodInfo(int inIndex)
        {
            int index = inIndex;
            return neighbourhoodArray[index].GetNeighbourhoodInfo();
        }

        // District Setter
        public void SetDistrictName(string inDistrictName)
        {
            districtName = inDistrictName;
        }
        public void SetNeighbourhoodsInDistrict(int inNeighbourhoodsInDistrict)
        {
            neighbourhoodsInDistrict = inNeighbourhoodsInDistrict;
        }

        //Neighbourhood Getters
        public int GetPropertiesInNeighbourhood(int inSelectedNeighbourhood)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPropertiesInNeighbourhood();

        }
        public string GetSelectedNeighbourhoodName(int inSelectedNeighbourhood)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            string neighbourhoodName = neighbourhoodArray[selectedNeighbourhood].GetNeighbourhoodName();
            return neighbourhoodName;
        }
        public string GetNeighbourhoodNames(int inSelectedNeighbourhood)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            string neighbourhoodName = neighbourhoodArray[selectedNeighbourhood].GetNeighbourhoodName();
            return neighbourhoodName;
        }


        //Neighbourhood Setters
        public void SetPropertiesInNeighbourhood(int inSelectedNeighbourhood, int inputPropertiesInNeighbourhood)
        {
            neighbourhoodArray[inSelectedNeighbourhood].SetPropertiesInNeighberhood(inputPropertiesInNeighbourhood);
        }
        public void SetNeighbourhoodName(int inSelectedNeighbourhood, string inputNeighbourhoodName)
        {
            neighbourhoodArray[inSelectedNeighbourhood].SetNeighbourhoodName(inputNeighbourhoodName);
        }
        public void AddNewNeighbourhood(Neighbourhood inputTmpNeighbourhood)
        {
            int currentNeighbourhoodSize = neighbourhoodArray.Length; //get array size
            Array.Resize(ref neighbourhoodArray, currentNeighbourhoodSize + 1); //make an array space
            neighbourhoodArray[currentNeighbourhoodSize] = inputTmpNeighbourhood;
        }

        //property getters

        public string GetPropertyDetails(int inSelectedProperty, int inSelectedNeighbouthood)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbouthood;
            string propDetails = neighbourhoodArray[selectedNeighbourhood].GetPropertyInfo(selectedProperty);
            return propDetails;
        }
        public string GetPropertyId(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPropertyId(selectedProperty);
        }
        public string GetPropertyName(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPropertyName(selectedProperty);
        }
        public string GetHostId(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetHostId(selectedProperty);
        }
        public string GetHostName(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetHostName(selectedProperty);
        }
        public string GetNumOfPropertiesString(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetNumOfProperties(selectedProperty).ToString();
        }
        public int GetNumOfProperties(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetNumOfProperties(selectedProperty);
        }
        public string GetLattitudeOfProperty(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetLattitudeOfProperty(selectedProperty);
        }
        public string GetLongitudeOfProperty(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetLongitudeOfProperty(selectedProperty);
        }
        public string GetRoomType(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetRoomType(selectedProperty);
        }
        public double GetPrice(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPrice(selectedProperty);
        }
        public string GetPriceString(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPrice(selectedProperty).ToString();
        }
        public string GetminNights(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetminNights(selectedProperty);
        }
        public string GetAvailability(int inSelectedNeighbourhood, int inSelectedProperty)
        {
            int selectedProperty = inSelectedProperty;
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetAvailability(selectedProperty);
        }

        public Property[] GetPropertyArray(int inSelectedNeighbourhood)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            return neighbourhoodArray[selectedNeighbourhood].GetPropertyArray();
        }

        //property setters
        public void AddNewProperty(int inSelectedNeighbourhood, Property inputTmpProperty)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            neighbourhoodArray[selectedNeighbourhood].AddNewProp(inputTmpProperty);
        }        
        public void SetEditedProperty(int inSelectedNeighbourhood, int inSelectedProperty, Property inputTmpProperty)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            neighbourhoodArray[selectedNeighbourhood].SetNewProperty(inSelectedProperty, inputTmpProperty);
        }

        public void SetPropertyArray(int inSelectedNeighbourhood, Property[] inLocalProperties)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            neighbourhoodArray[selectedNeighbourhood].SetPropertyArray(inLocalProperties);
        }

        public void SetPropertyId(int inSelectedNeighbourhood, int inCurrentProperty, string inPropertyID)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetPropertyId(currentProperty, inPropertyID);
        }
        public void SetPropertyName(int inSelectedNeighbourhood, int inCurrentProperty, string inPropertyName)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetPropertyId(currentProperty, inPropertyName);
        }
        public void SetHostId(int inSelectedNeighbourhood, int inCurrentProperty, string inHostId)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetHostId(currentProperty, inHostId);
        }
        public void SetHostName(int inSelectedNeighbourhood, int inCurrentProperty, string inHostName)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetHostName(currentProperty, inHostName);
        }
        public void SetNumOfProperties(int inSelectedNeighbourhood, int inCurrentProperty, int inNumOfProperties)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetNumOfProperties(currentProperty, inNumOfProperties);
        }
        public void SetLattitudeOfProperty(int inSelectedNeighbourhood, int inCurrentProperty, string inLattitudeOfProperty)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetLattitudeOfProperty(currentProperty, inLattitudeOfProperty);
        }
        public void SetLongitudeOfProperty(int inSelectedNeighbourhood, int inCurrentProperty, string inLongitudeOfProperty)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetLongitudeOfProperty(currentProperty, inLongitudeOfProperty);
        }
        public void SetRoomType(int inSelectedNeighbourhood, int inCurrentProperty, string inRoomType)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetRoomType(currentProperty, inRoomType);
        }
        public void SetPrice(int inSelectedNeighbourhood, int inCurrentProperty, double inPrice)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetPrice(currentProperty, inPrice);
        }
        public void SetminNights(int inSelectedNeighbourhood, int inCurrentProperty, string inMinNights)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetminNights(currentProperty, inMinNights);
        }
        public void SetAvailability(int inSelectedNeighbourhood, int inCurrentProperty, string inAvailability)
        {
            int selectedNeighbourhood = inSelectedNeighbourhood;
            int currentProperty = inCurrentProperty;
            neighbourhoodArray[selectedNeighbourhood].SetAvailability(currentProperty, inAvailability);
        }
    }
}
