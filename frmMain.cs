using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;


namespace Assignment_form
{
    public partial class frmMain : Form
    {
        public static frmMain frmKeepMain = null;
        public static int selectedDistrict;
        public static int selectedNeighbourhood;
        public static int selectedProperty;
        public static District[] districtArray = new District[0];
        public static Neighbourhood[] neighbourhoodArray = new Neighbourhood[0];
        public static Property[] propertyArray = new Property[0];
        private readonly OpenFileDialog loadDataFile = new OpenFileDialog();
        public static string dataFileLocation;

        public frmMain()
        {
            InitializeComponent();
            selectedDistrict = -1;
            selectedNeighbourhood = -1;
            selectedProperty = -1;
            frmKeepMain = this;
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {

        } //null
        
        private void DisplayDistrict()
        {
            lstDistrict.Items.Clear();

            foreach (District d in districtArray)
            {
                lstDistrict.Items.Add(d.GetDistrictName());
            }
            
            if (lstDistrict.SelectedIndex > -1)
            {
                DisplayNeighbourhood();
            }
            else
            {
                lstDistrict.SelectedIndex = 0;
                DisplayNeighbourhood();
            }
            if (lstNeighbourhood.SelectedIndex > -1)
            {
                DisplayProperties();
            }
            else
            {
                lstNeighbourhood.SelectedIndex = 0;
                DisplayProperties();
            }
        }

        private void DisplayNeighbourhood()
        {
            //read the number of nhoods in district
            int numNeighbourhoods = districtArray[selectedDistrict].GetNeighbourhoodsInDistrict();

            //clear the neighbouthood list box
            lstNeighbourhood.Items.Clear();

            //add neighbourhoods to nhood list box
            for (int i = 0; i < numNeighbourhoods; i++)
            {
                string neighbourhoodInfo = districtArray[selectedDistrict].GetNeighbourhoodNames(i);
                lstNeighbourhood.Items.Add(neighbourhoodInfo);
            }

            //display district name/no in district edit textbox
            txtDistrictName.Text = districtArray[selectedDistrict].GetDistrictName();
            txtNumNeighbourhoods.Text = numNeighbourhoods.ToString();

            //set selections
            lstNeighbourhood.SelectedIndex = 0;

        }

        private void DisplayProperties()
        {
            //read the number of properties in the selected neighbourhood
            int numProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);

            //display neighbourhood name in edit box
            txtNeighbourhoodName.Text = districtArray[selectedDistrict].GetSelectedNeighbourhoodName(selectedNeighbourhood);
            txtNumProperties.Text = numProperties.ToString();

            //display property details in edit boxes
            txtPropID.Text = frmMain.districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, selectedProperty);
            txtPropName.Text = frmMain.districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, selectedProperty);
            txtHostID.Text = frmMain.districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, selectedProperty);
            txtHostName.Text = frmMain.districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, selectedProperty);
            txtHostNumProp.Text = frmMain.districtArray[selectedDistrict].GetNumOfPropertiesString(selectedNeighbourhood, selectedProperty);
            txtLattitude.Text = frmMain.districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, selectedProperty);
            txtLongitude.Text = frmMain.districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, selectedProperty);
            txtRoomType.Text = frmMain.districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, selectedProperty);
            txtPrice.Text = frmMain.districtArray[selectedDistrict].GetPriceString(selectedNeighbourhood, selectedProperty);
            txtMinNumNights.Text = frmMain.districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, selectedProperty);
            txtAvailableDays.Text = frmMain.districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, selectedProperty);

            //set selection
            selectedProperty = dgdProperty.CurrentCell.RowIndex;

            SetupDataGrid();
        }

        private void BtnAddDistrict_Click(object sender, EventArgs e)
        {
            //create a temporary district from text box entries
            District tempDist = new District(txtDistrictName.Text, 0, neighbourhoodArray);

            if (txtDistrictName.Text == "")
            {
                MessageBox.Show("District Name Field must have a value!");
                txtDistrictName.Focus();
            }
            else
            {
                //add to array
                int currentDistSize = districtArray.Length; //get array size
                Array.Resize(ref districtArray, currentDistSize + 1); //make an array space
                frmMain.districtArray[currentDistSize] = tempDist; //add the new district to the new array space

                //write district to datafile

                //refresh the lists
                DisplayDistrict();
                lstDistrict.SelectedIndex = lstDistrict.Items.Count - 1;
                lstNeighbourhood.Items.Clear();
                //lstProperty.Items.Clear();

                //clear out neighbourhood & property text boxes
                ClearNeighbourhoodTextBoxes();
                ClearPropertyTextBoxes();

            }
        }

        private void BtnAddNeighbourhood_Click(object sender, EventArgs e)
        {
            //create a temp neighbourhood
            Neighbourhood tmpNeighbourhood = new Neighbourhood(txtNeighbourhoodName.Text, 0, propertyArray);

            if (txtNeighbourhoodName.Text == "")
            {
                MessageBox.Show("Neighbourhood Name Field must have a value!");
                txtNeighbourhoodName.Focus();
            }
            else
            {
                //increment neighbourhoods in distric number
                int currentNeighbourhoods = districtArray[selectedDistrict].GetNeighbourhoodsInDistrict();
                currentNeighbourhoods += 1;
                districtArray[selectedDistrict].SetNeighbourhoodsInDistrict(currentNeighbourhoods);

                //add to array
                districtArray[selectedDistrict].AddNewNeighbourhood(tmpNeighbourhood);

                //write to data file

                //refresh the list boxes
                DisplayNeighbourhood();
                lstNeighbourhood.SelectedIndex = lstNeighbourhood.Items.Count - 1;
                //lstProperty.SelectedIndex = -1;

                //clear out property text boxes
                ClearPropertyTextBoxes();
            }
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            bool inputValid = false;

            //get inputs
            string tmpPropID = txtPropID.Text;
            string tmpPropName = txtPropName.Text;
            string tmpHostID = txtHostID.Text;
            string tmpHostName = txtHostName.Text;
            int tmpNumProp = Convert.ToInt32(txtHostNumProp.Text);
            string tmpPropLatt = txtLattitude.Text;
            string tmpPropLong = txtLongitude.Text;
            string tmpRoomType = txtRoomType.Text;
            double tmpPrice = Convert.ToDouble(txtPrice.Text);
            string tmpMinNights = txtMinNumNights.Text;
            string tmpAvailableDays = txtAvailableDays.Text;

            //validate inputs
            inputValid = NotNullTextBox(txtPropID, "Property ID") &&
                            NotNullTextBox(txtPropName, "Property Name") &&
                                NotNullTextBox(txtHostID, "Host ID") &&
                                    NotNullTextBox(txtHostName, "Host Name") &&
                                        NotNullTextBox(txtHostNumProp, "Number of Host Properties") &&
                                            NotNullTextBox(txtLattitude, "Property Lattitude") &&
                                                NotNullTextBox(txtLongitude, "Property Longitude") &&
                                                    NotNullTextBox(txtRoomType, "Room type") &&
                                                        NotNullTextBox(txtPrice, "Property Price") &&
                                                            NotNullTextBox(txtMinNumNights, "Minimum number of nights") &&
                                                                NotNullTextBox(txtAvailableDays, "Number of days available");

            //create a temp Property
            Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt, 
                                                    tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

            //increment property in neighbourhood number
            int currentProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);
            currentProperties += 1;
            districtArray[selectedDistrict].SetPropertiesInNeighbourhood(selectedNeighbourhood, currentProperties);

            if (inputValid)
            {
                //add to array
                districtArray[selectedDistrict].AddNewProperty(selectedNeighbourhood, tmpProperty);

                //write to data file

                //refresh the list boxes
                DisplayProperties();
                //lstProperty.SelectedIndex = lstProperty.Items.Count - 1;
            }
        }

        private void BtnEditDist_Click(object sender, EventArgs e)
        {
            if (selectedDistrict > -1)
            {
                districtArray[selectedDistrict].SetDistrictName(txtDistrictName.Text);
                districtArray[selectedDistrict].SetNeighbourhoodsInDistrict(Convert.ToInt32(txtNumNeighbourhoods.Text));
            }
            else
            {
                MessageBox.Show("Please select an item to edit!");
            }
            //refresh the lists
            DisplayDistrict();
            lstDistrict.SelectedIndex = lstDistrict.Items.Count - 1;

            //clear out neighbourhood text boxes
            ClearNeighbourhoodTextBoxes();

        }
               
        private void BtnEditNeigh_Click(object sender, EventArgs e)
        {
            if (selectedNeighbourhood > -1)
            {
                districtArray[selectedDistrict].SetNeighbourhoodName(selectedNeighbourhood, txtNeighbourhoodName.Text);
                districtArray[selectedDistrict].SetPropertiesInNeighbourhood(selectedNeighbourhood, Convert.ToInt32(txtNumProperties.Text));
            }
            else
            {
                MessageBox.Show("Please select an item to edit!");
            }
            //refresh the lists
            //refresh the list boxes
            DisplayNeighbourhood();
            lstNeighbourhood.SelectedIndex = lstNeighbourhood.Items.Count - 1;

            //clear out property text boxes
            ClearPropertyTextBoxes();
        }

        private void BtnEditProp_Click(object sender, EventArgs e)
        {
            if (selectedProperty > -1)
            {
                bool inputValid = false;

                //get inputs
                string tmpPropID = txtPropID.Text;
                string tmpPropName = txtPropName.Text;
                string tmpHostID = txtHostID.Text;
                string tmpHostName = txtHostName.Text;
                int tmpNumProp = Convert.ToInt32(txtHostNumProp.Text);
                string tmpPropLatt = txtLattitude.Text;
                string tmpPropLong = txtLongitude.Text;
                string tmpRoomType = txtRoomType.Text;
                double tmpPrice = Convert.ToDouble(txtPrice.Text);
                string tmpMinNights = txtMinNumNights.Text;
                string tmpAvailableDays = txtAvailableDays.Text;

                //validate inputs
                inputValid = NotNullTextBox(txtPropID, "Property ID") &&
                                NotNullTextBox(txtPropName, "Property Name") &&
                                    NotNullTextBox(txtHostID, "Host ID") &&
                                        NotNullTextBox(txtHostName, "Host Name") &&
                                            NotNullTextBox(txtHostNumProp, "Number of Host Properties") &&
                                                NotNullTextBox(txtLattitude, "Property Lattitude") &&
                                                    NotNullTextBox(txtLongitude, "Property Longitude") &&
                                                        NotNullTextBox(txtRoomType, "Room type") &&
                                                            NotNullTextBox(txtPrice, "Property Price") &&
                                                                NotNullTextBox(txtMinNumNights, "Minimum number of nights") &&
                                                                    NotNullTextBox(txtAvailableDays, "Number of days available");

                //create a temp Property
                Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt,
                                                        tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

                //update details in the array
                districtArray[selectedDistrict].SetEditedProperty(selectedNeighbourhood, selectedProperty, tmpProperty);

                //refresh the list boxes
                DisplayProperties();
                //lstProperty.SelectedIndex = lstProperty.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Please select an item to edit!");
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (loadDataFile.FileName == "")
            {
                MessageBox.Show("Please select a datafile to load:");
                loadDataFile.ShowDialog();
                dataFileLocation = loadDataFile.FileName;
                LoadDataFileMethod(); //method to pass datafile into arrays
            }

            DisplayDistrict();
            DisplayNeighbourhood();
            DisplayProperties();
        }

        private void BtnDeleteDist_Click(object sender, EventArgs e)
        {
            districtArray[selectedDistrict] = null;
            int arraySize = districtArray.Length;
            SortDisrtictArray();
            Array.Resize(ref districtArray, arraySize - 1);
            ClearDistrictTextBoxes();
            ClearNeighbourhoodTextBoxes();
            ClearPropertyTextBoxes();
            MessageBox.Show("The selected District has been deleted!");
            DisplayDistrict();
        }

        private void BtnDeleteNeigh_Click(object sender, EventArgs e)
        {
            //set neighbourhood name to null
            districtArray[selectedDistrict].SetNeighbourhoodName(selectedNeighbourhood, "");
            districtArray[selectedDistrict].SetPropertiesInNeighbourhood(selectedNeighbourhood, 0);
            
            //tidy array to remove null objects
            int arraySize = districtArray[selectedDistrict].GetNeighbourhoodsInDistrict();
            SortNeighbourhoodArray();
            //Array.Resize(ref neighbourhoodArray, arraySize - 1);

            //tidy up form
            ClearNeighbourhoodTextBoxes();
            ClearPropertyTextBoxes();
            MessageBox.Show("The selected Neighbourhood has been deleted!");
            DisplayNeighbourhood();
        }
        
        private void BtnDeleteProperty_Click(object sender, EventArgs e)
        {
            //get inputs
            string tmpPropID = "";
            string tmpPropName = "";
            string tmpHostID = "";
            string tmpHostName = "";
            int tmpNumProp = 0;
            string tmpPropLatt = "";
            string tmpPropLong = "";
            string tmpRoomType = "";
            double tmpPrice = 0;
            string tmpMinNights = "";
            string tmpAvailableDays = "";

            //create a temp Property
            Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt,
                                                    tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

            districtArray[selectedDistrict].SetEditedProperty(selectedNeighbourhood, selectedProperty, tmpProperty);

            int arraySize = propertyArray.Length;
            SortPropertyArray();  
            ClearPropertyTextBoxes();
            MessageBox.Show("The selected Property has been deleted!");
            DisplayProperties();
        }

        private void LstDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            // set selected district
            selectedDistrict = lstDistrict.SelectedIndex;
            //check if district selected
            if (lstDistrict.SelectedIndex > -1) //checks if a district is selected
            {
                DisplayNeighbourhood();
            }
            else
            {
                lstDistrict.SelectedIndex = 0; //selects the first district
                DisplayNeighbourhood();
            }
            if (lstNeighbourhood.SelectedIndex > -1) //checks if a NHood is selected
            {
                DisplayProperties();
                selectedProperty = 0;
            }
            else if (lstNeighbourhood.Items.Count > 0)  //checks if a neighbourhood exists
            {
                lstNeighbourhood.SelectedIndex = 0;
                DisplayProperties();
                selectedProperty = 0;
            }
            else
            {
                MessageBox.Show("There are no Neighbourhoods in the selected District");
            }

        } //detects changes on district selection
               
        private void LstNeighbourhood_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set selected Neighbourhood
            selectedNeighbourhood = lstNeighbourhood.SelectedIndex;

            //check if neighbourhood selected
            if (lstNeighbourhood.SelectedIndex > -1) //checks if a nhood is selectced
            {
                SetupDataGrid(); //if yes, displays property
                DisplayProperties();
                selectedProperty = 0;
            }

            else
            {
                MessageBox.Show("There are no Properties in the selected Neighbourhood");
            }

        }  //detects changes on nhood selection

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            loadDataFile.ShowDialog();
            dataFileLocation = loadDataFile.FileName;
            LoadDataFileMethod(); //method to pass datafile into arrays
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //writeDataFile();
            loadDataFile.Dispose();
            this.Close();
        } //closes form & writes data back to file - disabled

        private void BtnClearProperty_Click(object sender, EventArgs e)
        {
            ClearDistrictTextBoxes();
            ClearNeighbourhoodTextBoxes();
            ClearPropertyTextBoxes();

        }  //clears all edit boxes

        public void SetupDataGrid()
        {
            

            //get number of properties
            int numProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);
            int numColumns = 11;

            string[,] matrix = new string[numProperties, numColumns];

            //set up datagrid
            dgdProperty.RowCount = numProperties;
            dgdProperty.ColumnCount = numColumns;
                                          
            //set DGD header labels
            dgdProperty.Columns[0].HeaderText = "Property ID";
            dgdProperty.Columns[1].HeaderText = "Property Name";
            dgdProperty.Columns[2].HeaderText = "Host ID";
            dgdProperty.Columns[3].HeaderText = "Host Name";
            dgdProperty.Columns[4].HeaderText = "Number of Properties";
            dgdProperty.Columns[5].HeaderText = "Property Lattitude";
            dgdProperty.Columns[6].HeaderText = "Property Longitude";
            dgdProperty.Columns[7].HeaderText = "Room Type";
            dgdProperty.Columns[8].HeaderText = "Price per Night";
            dgdProperty.Columns[9].HeaderText = "Min Number of Nights";
            dgdProperty.Columns[10].HeaderText = "Availabilty per Year";

            //set column widths
            dgdProperty.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgdProperty.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            //populate matrix

            for (int i = 0; i < numProperties; i++)
            {
                
                matrix[i, 0] = frmMain.districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, i);
                matrix[i, 1] = frmMain.districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, i);
                matrix[i, 2] = frmMain.districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, i);
                matrix[i, 3] = frmMain.districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, i);
                matrix[i, 4] = frmMain.districtArray[selectedDistrict].GetNumOfPropertiesString(selectedNeighbourhood, i);
                matrix[i, 5] = frmMain.districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, i);
                matrix[i, 6] = frmMain.districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, i);
                matrix[i, 7] = frmMain.districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, i);
                matrix[i, 8] = frmMain.districtArray[selectedDistrict].GetPriceString(selectedNeighbourhood, i);
                matrix[i, 9] = frmMain.districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, i);
                matrix[i, 10] = frmMain.districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, i);
            }

            //set the cell values
            for (int i = 0; i < numProperties; i++)
            {
                for (int j = 0; j < numColumns; j++)
                {
                    dgdProperty[j, i].Value = matrix[i, j];
                }
            }
            
            
        }        

        private bool NotNullTextBox(TextBox txtCurrent, string userFeedback)
        {
            //checks validity of inputs
            if (txtCurrent.Text == "")
            {
                MessageBox.Show("ERROR - The input for " + userFeedback + " Must contain a value!");

                txtCurrent.Focus();
                return false;
            }
            else
            {
                return true;
            }
        } //checks input boxes have a value before submission

        private void LoadDataFileMethod() //reads data file and loads all details to array.
        {
            

            string tmpDistrictName, tmpNeighbourhoodName, tmpPropID, tmpPropName, tmpHostID,
                    tmpHostName, tmpPropLat, tmpPropLong, tmpRoomType, tmpMinNights, tmpNightsAvailable;
            int tmpNumNeighbourhood, tmpNumPropInNeighbourhood, tmpHostPropNum;
            double tmpPrice;


            //run streamreader
            StreamReader loadDataIn = new StreamReader(dataFileLocation);

            //get districts
            while (!loadDataIn.EndOfStream)
            {
                //read file for districts
                tmpDistrictName = loadDataIn.ReadLine();
                tmpNumNeighbourhood = Convert.ToInt32(loadDataIn.ReadLine());

                //get neighbourhoods
                for (int j = 0; j < tmpNumNeighbourhood; j++)
                {
                    //read file for neighbourhoods
                    tmpNeighbourhoodName = loadDataIn.ReadLine();
                    tmpNumPropInNeighbourhood = Convert.ToInt32(loadDataIn.ReadLine());

                    //get properties
                    for (int k = 0; k < tmpNumPropInNeighbourhood; k++)
                    {
                        tmpPropID = loadDataIn.ReadLine();
                        tmpPropName = loadDataIn.ReadLine();
                        tmpHostID = loadDataIn.ReadLine();
                        tmpHostName = loadDataIn.ReadLine();
                        tmpHostPropNum = Convert.ToInt32(loadDataIn.ReadLine());
                        tmpPropLat = loadDataIn.ReadLine();
                        tmpPropLong = loadDataIn.ReadLine();
                        tmpRoomType = loadDataIn.ReadLine();
                        tmpPrice = Convert.ToInt32(loadDataIn.ReadLine());
                        tmpMinNights = loadDataIn.ReadLine();
                        tmpNightsAvailable = loadDataIn.ReadLine();

                        //create property
                        Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID,
                            tmpHostName, tmpHostPropNum, tmpPropLat, tmpPropLong, tmpRoomType,
                            tmpPrice, tmpMinNights, tmpNightsAvailable);

                        //Add to Property array
                        int currentPropertySize = frmMain.propertyArray.Length + 1; //get array size
                        Array.Resize(ref frmMain.propertyArray, currentPropertySize); //make an array space
                        frmMain.propertyArray[currentPropertySize - 1] = tmpProperty;
                    }

                    //create neighbourhood
                    Neighbourhood tmpNeighbourhood = new Neighbourhood(tmpNeighbourhoodName,
                                                                tmpNumPropInNeighbourhood, frmMain.propertyArray);
                    //Add to Neighbourhood array

                    int currentNeighbourhoodSize = frmMain.neighbourhoodArray.Length + 1; //get array size
                    Array.Resize(ref frmMain.neighbourhoodArray, currentNeighbourhoodSize); //make an array space
                    frmMain.neighbourhoodArray[currentNeighbourhoodSize - 1] = tmpNeighbourhood;

                    //clear prop array
                    frmMain.propertyArray = new Property[0];
                }

                //create district
                District tempDist = new District(tmpDistrictName, tmpNumNeighbourhood, frmMain.neighbourhoodArray);

                //add to District array

                int currentDistSize = frmMain.districtArray.Length + 1; //get array size
                Array.Resize(ref frmMain.districtArray, currentDistSize); //make an array space
                frmMain.districtArray[currentDistSize - 1] = tempDist;

                //clear neighbourhood array
                frmMain.neighbourhoodArray = new Neighbourhood[0];
            }
            loadDataIn.Close();
        }

        private void ClearDistrictTextBoxes()
        {
            txtDistrictName.Text = "";
            txtNumNeighbourhoods.Text = "";
        }

        private void ClearNeighbourhoodTextBoxes()
        {
            txtNeighbourhoodName.Text = "";
            txtNumProperties.Text = "";
        }

        private void ClearPropertyTextBoxes()
        {
            txtPropID.Text = "";
            txtPropName.Text = "";
            txtHostID.Text = "";
            txtHostName.Text = "";
            txtHostNumProp.Text = "";
            txtLattitude.Text = "";
            txtLongitude.Text = "";
            txtRoomType.Text = "";
            txtPrice.Text = "";
            txtMinNumNights.Text = "";
            txtAvailableDays.Text = "";
        }

        private void SortDisrtictArray()
        {
            int arrayLength = districtArray.Length;
            int start = 0;
            int end = arrayLength - 1;
            District[] tmp = new District[arrayLength];

            for (int i = 0; i < districtArray.Length; i++)
            {
                if (districtArray[i] == null)
                {
                    tmp[end] = districtArray[i];
                    end--;
                }
                else
                {
                    tmp[start] = districtArray[i];
                    start++;
                }
            }

            for (int i = 0; i < districtArray.Length; i++)
            {
                if (tmp[i] == null)
                {
                    districtArray[start] = tmp[i];
                    start++;
                }
                else
                {
                    districtArray[end] = tmp[i];
                    end--;
                }
            }
        }

        private void SortNeighbourhoodArray()
        {

            int arrayLength = districtArray[selectedDistrict].GetNeighbourhoodsInDistrict();
            int start = 0;
            int end = arrayLength - 1;
            string tmpNHoodName;
            int tmpPropInNHood;
            Neighbourhood[] tmpNHoodArray = new Neighbourhood[arrayLength];


            //read from neighbourhood array and write to temp array
            for (int i = 0; i < arrayLength; i++)
            {
                //read neighbourhood name
                tmpNHoodName = districtArray[selectedDistrict].GetNeighbourhoodNames(i);
                //read num props in nhood
                tmpPropInNHood = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(i);
                //read the property arrays
                if (tmpPropInNHood == 0)
                {
                    tmpPropInNHood = 1;
                }
                Property[] tmpPropArray = new Property[tmpPropInNHood - 1];
                tmpPropArray = districtArray[selectedDistrict].GetPropertyArray(i);
                //create temp nhood
                Neighbourhood tmpNeighbourhood = new Neighbourhood(tmpNHoodName, tmpPropInNHood, tmpPropArray);

                //if not blank add to start of temp array
                if (districtArray[selectedDistrict].GetNeighbourhoodNames(i) != "")
                {
                    tmpNHoodArray[start] = tmpNeighbourhood;
                    start++;
                }
                //if blank add to end of temp array
                else if (districtArray[selectedDistrict].GetNeighbourhoodNames(i) == "")
                {
                    tmpNHoodArray[end] = tmpNeighbourhood;
                    end--;
                }

            }
            //add temp array back into neighbourhood array
            for (int j = 0; j < arrayLength; j++)
            {
                districtArray[selectedDistrict].SetNeighbourhoodName(j, tmpNHoodArray[j].GetNeighbourhoodName());
                districtArray[selectedDistrict].SetPropertiesInNeighbourhood(j, tmpNHoodArray[j].GetPropertiesInNeighbourhood());
                districtArray[selectedDistrict].SetPropertyArray(j, tmpNHoodArray[j].GetPropertyArray());
            }

            //update number of nhoods in dist
            int currentNeighbourhoods = districtArray[selectedDistrict].GetNeighbourhoodsInDistrict();
            currentNeighbourhoods -= 1;
            districtArray[selectedDistrict].SetNeighbourhoodsInDistrict(currentNeighbourhoods);

        }

        private void SortPropertyArray()
        {
            int arrayLength = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);
            int start = 0;
            int end = arrayLength - 1;
            Property[] tmpPropertyArray = new Property[arrayLength];
            string tmpPropID;
            string tmpPropName;
            string tmpHostID;
            string tmpHostName;
            int tmpNumProp;
            string tmpPropLatt;
            string tmpPropLong;
            string tmpRoomType;
            double tmpPrice;
            string tmpMinNights;
            string tmpAvailableDays;

            for (int i = 0; i < arrayLength; i++)
            {
                //read from property array
                tmpPropID = districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, i);
                tmpPropName = districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, i);
                tmpHostID = districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, i);
                tmpHostName = districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, i);
                tmpNumProp = districtArray[selectedDistrict].GetNumOfProperties(selectedNeighbourhood, i);
                tmpPropLatt = districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, i);
                tmpPropLong = districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, i);
                tmpRoomType = districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, i);
                tmpPrice = districtArray[selectedDistrict].GetPrice(selectedNeighbourhood, i);
                tmpMinNights = districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, i);
                tmpAvailableDays = districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, i);

                //create new temp property
                Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt,
                                                    tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

                //if property name is not blank add to start of temp array
                if (tmpPropName != "")
                {
                    tmpPropertyArray[start] = tmpProperty;
                    start++;
                }
                //if property name is blank, add to end of temp array
                else if (tmpPropName == "")
                {
                    tmpPropertyArray[end] = tmpProperty;
                    end--;
                }

            }

            //add temp array back into property array
            for (int j = 0; j < arrayLength; j++)
            {
                tmpPropID = tmpPropertyArray[j].GetPropertyId();
                tmpPropName = tmpPropertyArray[j].GetPropertyName();
                tmpHostID = tmpPropertyArray[j].GetHostId();
                tmpHostName = tmpPropertyArray[j].GetHostName();
                tmpNumProp = tmpPropertyArray[j].GetNumOfProperties();
                tmpPropLatt = tmpPropertyArray[j].GetLattitudeOfProperty();
                tmpPropLong = tmpPropertyArray[j].GetLongitudeOfProperty();
                tmpRoomType = tmpPropertyArray[j].GetRoomType();
                tmpPrice = tmpPropertyArray[j].GetPrice();
                tmpMinNights = tmpPropertyArray[j].GetminNights();
                tmpAvailableDays = tmpPropertyArray[j].GetAvailability();
                Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt,
                                                    tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

                districtArray[selectedDistrict].SetEditedProperty(selectedNeighbourhood, j, tmpProperty);

            }
            //update num props in nhood
            int currentProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);
            currentProperties -= 1;
            districtArray[selectedDistrict].SetPropertiesInNeighbourhood(selectedNeighbourhood, currentProperties);
        }

        private void WriteDataFile()
        {
            //run streamwriter
            StreamWriter writeDataOut = new StreamWriter(dataFileLocation);
            int numDistricts = districtArray.Length;

            for (int i = 0; i < numDistricts; i++)       

            {
                writeDataOut.WriteLine(districtArray[i].GetDistrictName());
                int numNhoodsInDist = districtArray[i].GetNeighbourhoodsInDistrict();
                writeDataOut.WriteLine(numNhoodsInDist);


                for (int j = 0; j < numNhoodsInDist; j++)
                {
                    writeDataOut.WriteLine(districtArray[i].GetNeighbourhoodNames(j));
                    int numPropInNhood = districtArray[i].GetPropertiesInNeighbourhood(j);
                    writeDataOut.WriteLine(numPropInNhood);

                    for (int k = 0; k < numPropInNhood; k++)
                    {
                        writeDataOut.WriteLine(districtArray[i].GetPropertyId(j,k));
                        writeDataOut.WriteLine(districtArray[i].GetPropertyName(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetHostId(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetHostName(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetNumOfProperties(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetLattitudeOfProperty(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetLongitudeOfProperty(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetRoomType(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetPrice(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetminNights(j, k));
                        writeDataOut.WriteLine(districtArray[i].GetAvailability(j, k));
                    }
                }

            }
            writeDataOut.Close();
            
        } //currently disabled - enable in btnExit_Click() function

        private void DgdProperty_SelectionChanged(object sender, EventArgs e)
        {
            selectedProperty = dgdProperty.CurrentCell.RowIndex;
            //check that a property is selected and warn if not
            if (selectedProperty == -1)
            {
                selectedProperty = 0;
            }

            //display property details in edit text boxes
            DisplayProperties();

            SetupDataGrid();
        }

        private void btnDistrictSearch_Click(object sender, EventArgs e)
        {
            int numDist = districtArray.Length;
            string search = txtDistrictSearch.Text;
            for (int i = 0; i < numDist; i++)
            {           
                if (districtArray[i].GetDistrictName().ToLower() != search.ToLower())
                {
                    txtDistrictSearch.Text = "District not found!";                   
                }
                else
                {
                    lstDistrict.SelectedIndex = i;
                    txtDistrictSearch.Text = "District found!";
                    i = numDist;
                }
            }
        }

        private void txtDistrictSearch_Click(object sender, EventArgs e)
        {
            txtDistrictSearch.Text = "";
            txtNeighbourhoodSearch.ForeColor = Color.Black;
        }

        private void txtNeighbourhoodSearch_Click(object sender, EventArgs e)
        {
            txtNeighbourhoodSearch.Text = "";
            txtNeighbourhoodSearch.ForeColor = Color.Black;
        }

        private void btnNeighbourhoodSearch_Click(object sender, EventArgs e)
        {
            int numDist = districtArray.Length;
            string search = txtNeighbourhoodSearch.Text;

            for (int i = 0; i < numDist; i++)
            {
                int numNeigh = districtArray[i].GetNeighbourhoodsInDistrict();
                for (int j = 0; j < numNeigh; j++)
                {
                    if (districtArray[i].GetNeighbourhoodNames(j).ToLower() != search.ToLower())
                    {
                        txtNeighbourhoodSearch.Text = "District not found!";
                    }
                    else
                    {
                        lstDistrict.SelectedIndex = i;
                        lstNeighbourhood.SelectedIndex = j;
                        txtNeighbourhoodSearch.Text = "Neighbourhood found!";
                        j = numNeigh;
                        i = numDist;
                    }
                    
                }
            }
        }
    }                
}
