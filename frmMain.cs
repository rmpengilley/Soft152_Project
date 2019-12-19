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
    public partial class FrmMain : Form
    {
        public static FrmMain frmKeepMain = null;
        public static int selectedDistrict;
        public static int selectedNeighbourhood;
        public static int selectedProperty;
        public static District[] districtArray = new District[0];
        public static Neighbourhood[] neighbourhoodArray = new Neighbourhood[0];
        public static Property[] propertyArray = new Property[0];
        private readonly OpenFileDialog loadDataFile = new OpenFileDialog();
        public static string dataFileLocation;

        public FrmMain()
        {
            InitializeComponent();
            selectedDistrict = -1;
            selectedNeighbourhood = -1;
            selectedProperty = -1;
            frmKeepMain = this;
        }

        public void FrmMain_Load()
        {

        }
        
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
            if (selectedNeighbourhood > 0)
            {
                lstNeighbourhood.SelectedIndex = 0;
            }
        }

        private void DisplayProperties()
        {
            //read the number of properties in the selected neighbourhood
            int numProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);

            //display neighbourhood name in edit box
            txtNeighbourhoodName.Text = districtArray[selectedDistrict].GetSelectedNeighbourhoodName(selectedNeighbourhood);
            txtNumProperties.Text = numProperties.ToString();

            if (numProperties > 0)
            {
                //display property details in edit boxes
                txtPropID.Text = FrmMain.districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, selectedProperty);
                txtPropName.Text = FrmMain.districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, selectedProperty);
                txtHostID.Text = FrmMain.districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, selectedProperty);
                txtHostName.Text = FrmMain.districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, selectedProperty);
                txtHostNumProp.Text = FrmMain.districtArray[selectedDistrict].GetNumOfPropertiesString(selectedNeighbourhood, selectedProperty);
                txtLattitude.Text = FrmMain.districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, selectedProperty);
                txtLongitude.Text = FrmMain.districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, selectedProperty);
                txtRoomType.Text = FrmMain.districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, selectedProperty);
                txtPrice.Text = FrmMain.districtArray[selectedDistrict].GetPriceString(selectedNeighbourhood, selectedProperty);
                txtMinNumNights.Text = FrmMain.districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, selectedProperty);
                txtAvailableDays.Text = FrmMain.districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, selectedProperty);

                //set selection
                selectedProperty = dgdProperty.CurrentCell.RowIndex;

                //write properties to data grid view
                SetupDataGrid();
            }
           
        }

        private void BtnAddDistrict_Click(object sender, EventArgs e)
        {
            txtDistrictName.Text = "";
            txtDistrictName.Focus();
            btnAddDistrict.Enabled = false;
            btnEditDist.Enabled = false;
            btnDistAddSave.Show();
            btnEditDistSave.Hide();
            btnDistCancel.Show();
        }

        private void BtnAddNeighbourhood_Click(object sender, EventArgs e)
        {
            txtNeighbourhoodName.Text = "";
            txtNeighbourhoodName.Focus();
            btnAddNeighbourhood.Enabled = false;
            btnEditNeigh.Enabled = false;
            btnNeighAddSave.Show();
            btnEditNeighSave.Hide();
            btnNeighCancel.Show();
        }

        private void BtnAddProperty_Click(object sender, EventArgs e)
        {
            ClearPropertyTextBoxes();
            btnAddProperty.Enabled = false;
            btnEditProp.Enabled = false;
            btnDeleteProperty.Enabled = false;
            btnAddPropSave.Show();
            btnPropCancel.Show();
        }

        private void BtnEditDist_Click(object sender, EventArgs e)
        {
            txtDistrictName.Focus();
            btnAddDistrict.Enabled = false;
            btnEditDist.Enabled = false;
            btnDistAddSave.Hide();
            btnEditDistSave.Show();
            btnDistCancel.Show();
        }
               
        private void BtnEditNeigh_Click(object sender, EventArgs e)
        {
            txtNeighbourhoodName.Focus();
            btnAddNeighbourhood.Enabled = false;
            btnEditNeigh.Enabled = false;
            btnNeighAddSave.Hide();
            btnEditNeighSave.Show();
            btnNeighCancel.Show();
        }

        private void BtnEditProp_Click(object sender, EventArgs e)
        {
            btnAddProperty.Enabled = false;
            btnEditProp.Enabled = false;
            btnDeleteProperty.Enabled = false;
            btnEditPropSave.Show();
            btnPropCancel.Show();
        }

        private void ShowData()
        {
            //checks a file has been selected and shows contents read in
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
        
        private void BtnDeleteProperty_Click(object sender, EventArgs e)
        {
            //change buttons
            btnEditProp.Enabled = false;
            btnAddProperty.Enabled = false;
            btnDeleteProperty.Enabled = false;
            btnAddPropSave.Hide();
            btnPropCancel.Show();
            btnPropDelConfirm.Show();
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
            //Allows the user to select the data file location
            loadDataFile.ShowDialog();
            dataFileLocation = loadDataFile.FileName;
            LoadDataFileMethod(); //method to pass datafile into arrays            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            WriteDataFile();
            loadDataFile.Dispose();
            this.Close();
        } //closes form & writes data back to file

        public void SetupDataGrid()
        {          
            //get number of properties
            int numProperties = districtArray[selectedDistrict].GetPropertiesInNeighbourhood(selectedNeighbourhood);
            int numColumns = 11;
            if (numProperties > 0)
            {
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
                    matrix[i, 0] = FrmMain.districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, i);
                    matrix[i, 1] = FrmMain.districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, i);
                    matrix[i, 2] = FrmMain.districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, i);
                    matrix[i, 3] = FrmMain.districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, i);
                    matrix[i, 4] = FrmMain.districtArray[selectedDistrict].GetNumOfPropertiesString(selectedNeighbourhood, i);
                    matrix[i, 5] = FrmMain.districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, i);
                    matrix[i, 6] = FrmMain.districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, i);
                    matrix[i, 7] = FrmMain.districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, i);
                    matrix[i, 8] = FrmMain.districtArray[selectedDistrict].GetPriceString(selectedNeighbourhood, i);
                    matrix[i, 9] = FrmMain.districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, i);
                    matrix[i, 10] = FrmMain.districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, i);
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
            else
            {
                MessageBox.Show("there are no properties to display");
                selectedProperty = -1;
                dgdProperty.Columns.Clear();

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
                        int currentPropertySize = FrmMain.propertyArray.Length + 1; //get array size
                        Array.Resize(ref FrmMain.propertyArray, currentPropertySize); //make an array space
                        FrmMain.propertyArray[currentPropertySize - 1] = tmpProperty;
                    }

                    //create neighbourhood
                    Neighbourhood tmpNeighbourhood = new Neighbourhood(tmpNeighbourhoodName,
                                                                tmpNumPropInNeighbourhood, FrmMain.propertyArray);
                    //Add to Neighbourhood array

                    int currentNeighbourhoodSize = FrmMain.neighbourhoodArray.Length + 1; //get array size
                    Array.Resize(ref FrmMain.neighbourhoodArray, currentNeighbourhoodSize); //make an array space
                    FrmMain.neighbourhoodArray[currentNeighbourhoodSize - 1] = tmpNeighbourhood;

                    //clear prop array
                    FrmMain.propertyArray = new Property[0];
                }

                //create district
                District tempDist = new District(tmpDistrictName, tmpNumNeighbourhood, FrmMain.neighbourhoodArray);

                //add to District array

                int currentDistSize = FrmMain.districtArray.Length + 1; //get array size
                Array.Resize(ref FrmMain.districtArray, currentDistSize); //make an array space
                FrmMain.districtArray[currentDistSize - 1] = tempDist;

                //clear neighbourhood array
                FrmMain.neighbourhoodArray = new Neighbourhood[0];
            }
            loadDataIn.Close();
            ShowData();
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
            //Create streamwriter
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
            //check that a property is selected, and select first row if not
            if (selectedProperty == -1)
            {
                selectedProperty = 0;
            }

            //display property details in edit text boxes
            DisplayProperties();

            SetupDataGrid();
        }

        private void DistrictSearch()
        {
            //set selections
            lstNeighbourhood.SelectedIndex = 0;
            dgdProperty.ClearSelection();
            dgdProperty.Rows[0].Selected = true;
            selectedProperty = 0;


            int numDist = districtArray.Length;
            string search = TxtDistrictSearch.Text.ToLower();
            int searchLength = search.Length;
            int k = searchLength;
            for (int i = 0; i < districtArray.Length; i++)
            {
                string distName = districtArray[i].GetDistrictName().ToLower();
                for (int j = 0; j + k < distName.Length; j++)
                {
                    
                    if (distName.Substring(j,k) == search)
                    {
                        k++;
                        lstDistrict.SelectedIndex = i;
                        i = districtArray.Length;
                    }
                }                    
            }
        }

        private void TxtDistrictSearch_KeyUp(object sender, KeyEventArgs e)
        {
            dgdProperty.ClearSelection();
            dgdProperty.Rows[0].Selected = true;
            DistrictSearch();
        }

        private void TxtDistrictSearch_Click(object sender, EventArgs e)
        {
            TxtDistrictSearch.Text = "";
            TxtDistrictSearch.ForeColor = Color.Black;
            dgdProperty.ClearSelection();
            dgdProperty.Rows[0].Selected = true;
        }

        private void BtnAddPropSave_Click(object sender, EventArgs e)
        {
            bool inputValid = false;

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

                //refresh the list boxes
                DisplayProperties();
            }

            //restore button defaults
            btnAddProperty.Enabled = true;
            btnEditProp.Enabled = true;
            btnDeleteProperty.Enabled = true;
            btnAddPropSave.Hide();
            btnPropCancel.Hide();

            //Write data back to file
            WriteDataFile();
        }

        private void BtnEditPropSave_Click(object sender, EventArgs e)
        {
            if (selectedProperty > -1)
            {
                bool inputValid = false;                

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

                //create a temp Property
                Property tmpProperty = new Property(tmpPropID, tmpPropName, tmpHostID, tmpHostName, tmpNumProp, tmpPropLatt,
                                                        tmpPropLong, tmpRoomType, tmpPrice, tmpMinNights, tmpAvailableDays);

                if (inputValid)
                {
                    //update details in the array
                    districtArray[selectedDistrict].SetEditedProperty(selectedNeighbourhood, selectedProperty, tmpProperty);

                    //refresh the list boxes
                    DisplayProperties();
                }

            }
            else
            {
                MessageBox.Show("Please select an item to edit!");
            }

            //restore button defaults
            btnAddProperty.Enabled = true;
            btnEditProp.Enabled = true;
            btnDeleteProperty.Enabled = true;
            btnEditPropSave.Hide();
            btnPropCancel.Hide();

            //Write data back to file
            WriteDataFile();
        } 

        private void BtnPropCancel_Click(object sender, EventArgs e)
        {
            ClearPropertyTextBoxes();
            btnAddProperty.Enabled = true;
            btnDeleteProperty.Enabled = true;
            btnEditProp.Enabled = true;
            //display property details in edit boxes
            txtPropID.Text = FrmMain.districtArray[selectedDistrict].GetPropertyId(selectedNeighbourhood, selectedProperty);
            txtPropName.Text = FrmMain.districtArray[selectedDistrict].GetPropertyName(selectedNeighbourhood, selectedProperty);
            txtHostID.Text = FrmMain.districtArray[selectedDistrict].GetHostId(selectedNeighbourhood, selectedProperty);
            txtHostName.Text = FrmMain.districtArray[selectedDistrict].GetHostName(selectedNeighbourhood, selectedProperty);
            txtHostNumProp.Text = FrmMain.districtArray[selectedDistrict].GetNumOfPropertiesString(selectedNeighbourhood, selectedProperty);
            txtLattitude.Text = FrmMain.districtArray[selectedDistrict].GetLattitudeOfProperty(selectedNeighbourhood, selectedProperty);
            txtLongitude.Text = FrmMain.districtArray[selectedDistrict].GetLongitudeOfProperty(selectedNeighbourhood, selectedProperty);
            txtRoomType.Text = FrmMain.districtArray[selectedDistrict].GetRoomType(selectedNeighbourhood, selectedProperty);
            txtPrice.Text = FrmMain.districtArray[selectedDistrict].GetPriceString(selectedNeighbourhood, selectedProperty);
            txtMinNumNights.Text = FrmMain.districtArray[selectedDistrict].GetminNights(selectedNeighbourhood, selectedProperty);
            txtAvailableDays.Text = FrmMain.districtArray[selectedDistrict].GetAvailability(selectedNeighbourhood, selectedProperty);
            btnEditPropSave.Hide();
            btnAddPropSave.Hide();
            btnPropDelConfirm.Hide();
            btnPropCancel.Hide();
        }
     
        private void BtnPropDelConfirm_Click(object sender, EventArgs e)
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

            //change buttons
            btnEditProp.Enabled = true;
            btnAddProperty.Enabled = true;
            btnDeleteProperty.Enabled = true;
            btnAddPropSave.Hide();
            btnPropCancel.Hide();
            btnPropDelConfirm.Hide();

            //Write data back to file
            WriteDataFile();
        } 

        private void BtnDistAddSave_Click(object sender, EventArgs e)
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
                FrmMain.districtArray[currentDistSize] = tempDist; //add the new district to the new array space

                //write district to datafile

                //refresh the lists
                DisplayDistrict();
                lstDistrict.SelectedIndex = lstDistrict.Items.Count - 1;
                lstNeighbourhood.Items.Clear();
                

                //clear out neighbourhood & property text boxes
                ClearNeighbourhoodTextBoxes();
                ClearPropertyTextBoxes();

                btnAddDistrict.Enabled = true;
                btnEditDist.Enabled = true;
                btnDistAddSave.Hide();
                btnEditDistSave.Hide();
                btnDistCancel.Hide();
            }
            //Write data back to file
            WriteDataFile();
        } 

        private void BtnEditDistSave_Click(object sender, EventArgs e)
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

            btnAddDistrict.Enabled = true;
            btnEditDist.Enabled = true;
            btnDistAddSave.Hide();
            btnEditDistSave.Hide();
            btnDistCancel.Hide();

            //Write data back to file
            WriteDataFile();
        } 

        private void BtnDistCancel_Click(object sender, EventArgs e)
        {
            btnAddDistrict.Enabled = true;
            btnEditDist.Enabled = true;
            txtDistrictName.Text = districtArray[selectedDistrict].GetDistrictName();
            btnDistAddSave.Hide();
            btnEditDistSave.Hide();
            btnDistCancel.Hide();
        }

        private void BtnNeighCancel_Click(object sender, EventArgs e)
        {
            btnAddNeighbourhood.Enabled = true;
            btnEditNeigh.Enabled = true;
            txtNeighbourhoodName.Text = districtArray[selectedDistrict].GetSelectedNeighbourhoodName(selectedNeighbourhood);
            btnNeighAddSave.Hide();
            btnEditNeighSave.Hide();
            btnNeighCancel.Hide();
        }

        private void BtnNeighAddSave_Click(object sender, EventArgs e)
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

                //clear out property text boxes
                ClearPropertyTextBoxes();
            }

            btnAddNeighbourhood.Enabled = true;
            btnEditNeigh.Enabled = true;
            btnNeighAddSave.Hide();
            btnEditNeighSave.Hide();
            btnNeighCancel.Hide();

            //Write data back to file
            WriteDataFile();
        } 

        private void BtnEditNeighSave_Click(object sender, EventArgs e)
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
            //refresh the list boxes
            DisplayNeighbourhood();
            lstNeighbourhood.SelectedIndex = lstNeighbourhood.Items.Count - 1;

            //clear out property text boxes
            ClearPropertyTextBoxes();

            btnAddNeighbourhood.Enabled = true;
            btnEditNeigh.Enabled = true;
            btnNeighAddSave.Hide();
            btnEditNeighSave.Hide();
            btnNeighCancel.Hide();

            //Write data back to file
            WriteDataFile();
        } 
    }                
}
