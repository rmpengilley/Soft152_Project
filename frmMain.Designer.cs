namespace Assignment_form
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnAddNeighbourhood = new System.Windows.Forms.Button();
            this.btnAddDistrict = new System.Windows.Forms.Button();
            this.lstDistrict = new System.Windows.Forms.ListBox();
            this.btnEditProp = new System.Windows.Forms.Button();
            this.btnEditNeigh = new System.Windows.Forms.Button();
            this.btnEditDist = new System.Windows.Forms.Button();
            this.lstNeighbourhood = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDistrictName = new System.Windows.Forms.TextBox();
            this.txtNeighbourhoodName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txtAvailableDays = new System.Windows.Forms.TextBox();
            this.txtPropName = new System.Windows.Forms.TextBox();
            this.txtHostID = new System.Windows.Forms.TextBox();
            this.txtHostName = new System.Windows.Forms.TextBox();
            this.txtHostNumProp = new System.Windows.Forms.TextBox();
            this.txtLattitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMinNumNights = new System.Windows.Forms.TextBox();
            this.txtPropID = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPropDelConfirm = new System.Windows.Forms.Button();
            this.btnPropCancel = new System.Windows.Forms.Button();
            this.btnEditPropSave = new System.Windows.Forms.Button();
            this.btnAddPropSave = new System.Windows.Forms.Button();
            this.dgdProperty = new System.Windows.Forms.DataGridView();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNeighCancel = new System.Windows.Forms.Button();
            this.btnEditNeighSave = new System.Windows.Forms.Button();
            this.btnNeighAddSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumProperties = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDistCancel = new System.Windows.Forms.Button();
            this.btnEditDistSave = new System.Windows.Forms.Button();
            this.btnDistAddSave = new System.Windows.Forms.Button();
            this.TxtDistrictSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumNeighbourhoods = new System.Windows.Forms.TextBox();
            this.lblDistrictSearch = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProperty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(1777, 64);
            this.btnAddProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(227, 30);
            this.btnAddProperty.TabIndex = 3;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.BtnAddProperty_Click);
            // 
            // btnAddNeighbourhood
            // 
            this.btnAddNeighbourhood.Location = new System.Drawing.Point(846, 36);
            this.btnAddNeighbourhood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNeighbourhood.Name = "btnAddNeighbourhood";
            this.btnAddNeighbourhood.Size = new System.Drawing.Size(230, 30);
            this.btnAddNeighbourhood.TabIndex = 4;
            this.btnAddNeighbourhood.Text = "Add Neighbourhood";
            this.btnAddNeighbourhood.UseVisualStyleBackColor = true;
            this.btnAddNeighbourhood.Click += new System.EventHandler(this.BtnAddNeighbourhood_Click);
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Location = new System.Drawing.Point(679, 38);
            this.btnAddDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(227, 31);
            this.btnAddDistrict.TabIndex = 5;
            this.btnAddDistrict.Text = "Add District";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.BtnAddDistrict_Click);
            // 
            // lstDistrict
            // 
            this.lstDistrict.FormattingEnabled = true;
            this.lstDistrict.ItemHeight = 20;
            this.lstDistrict.Location = new System.Drawing.Point(13, 78);
            this.lstDistrict.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstDistrict.Name = "lstDistrict";
            this.lstDistrict.Size = new System.Drawing.Size(181, 104);
            this.lstDistrict.TabIndex = 6;
            this.lstDistrict.SelectedIndexChanged += new System.EventHandler(this.LstDistrict_SelectedIndexChanged);
            // 
            // btnEditProp
            // 
            this.btnEditProp.Location = new System.Drawing.Point(1777, 102);
            this.btnEditProp.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProp.Name = "btnEditProp";
            this.btnEditProp.Size = new System.Drawing.Size(227, 30);
            this.btnEditProp.TabIndex = 7;
            this.btnEditProp.Text = "Edit Property";
            this.btnEditProp.UseVisualStyleBackColor = true;
            this.btnEditProp.Click += new System.EventHandler(this.BtnEditProp_Click);
            // 
            // btnEditNeigh
            // 
            this.btnEditNeigh.Location = new System.Drawing.Point(846, 74);
            this.btnEditNeigh.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditNeigh.Name = "btnEditNeigh";
            this.btnEditNeigh.Size = new System.Drawing.Size(230, 30);
            this.btnEditNeigh.TabIndex = 8;
            this.btnEditNeigh.Text = "Edit Neighbourhood";
            this.btnEditNeigh.UseVisualStyleBackColor = true;
            this.btnEditNeigh.Click += new System.EventHandler(this.BtnEditNeigh_Click);
            // 
            // btnEditDist
            // 
            this.btnEditDist.Location = new System.Drawing.Point(679, 76);
            this.btnEditDist.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditDist.Name = "btnEditDist";
            this.btnEditDist.Size = new System.Drawing.Size(227, 31);
            this.btnEditDist.TabIndex = 9;
            this.btnEditDist.Text = "Edit District";
            this.btnEditDist.UseVisualStyleBackColor = true;
            this.btnEditDist.Click += new System.EventHandler(this.BtnEditDist_Click);
            // 
            // lstNeighbourhood
            // 
            this.lstNeighbourhood.FormattingEnabled = true;
            this.lstNeighbourhood.ItemHeight = 20;
            this.lstNeighbourhood.Location = new System.Drawing.Point(35, 38);
            this.lstNeighbourhood.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lstNeighbourhood.Name = "lstNeighbourhood";
            this.lstNeighbourhood.Size = new System.Drawing.Size(295, 144);
            this.lstNeighbourhood.TabIndex = 11;
            this.lstNeighbourhood.SelectedIndexChanged += new System.EventHandler(this.LstNeighbourhood_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(0, 0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 110;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(32, 896);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(173, 49);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load data File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1857, 896);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(173, 50);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(376, 178);
            this.txtDistrictName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(277, 26);
            this.txtDistrictName.TabIndex = 19;
            // 
            // txtNeighbourhoodName
            // 
            this.txtNeighbourhoodName.Location = new System.Drawing.Point(564, 178);
            this.txtNeighbourhoodName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeighbourhoodName.Name = "txtNeighbourhoodName";
            this.txtNeighbourhoodName.Size = new System.Drawing.Size(257, 26);
            this.txtNeighbourhoodName.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(471, 25);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(15, 20);
            this.label23.TabIndex = 104;
            this.label23.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(655, 63);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 20);
            this.label22.TabIndex = 103;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(315, 98);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 20);
            this.label21.TabIndex = 102;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(476, 134);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 20);
            this.label20.TabIndex = 101;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(983, 27);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 20);
            this.label19.TabIndex = 100;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1477, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 20);
            this.label18.TabIndex = 99;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1477, 59);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 20);
            this.label17.TabIndex = 98;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1551, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 20);
            this.label16.TabIndex = 97;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1128, 123);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 20);
            this.label15.TabIndex = 96;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1056, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 20);
            this.label14.TabIndex = 95;
            this.label14.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1057, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 20);
            this.label12.TabIndex = 94;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 93;
            this.label13.Text = "Property ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1156, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 20);
            this.label11.TabIndex = 92;
            this.label11.Text = "Availability (Days Per Year):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1160, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(218, 20);
            this.label10.TabIndex = 91;
            this.label10.Text = "Minimum Number of Nights:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1343, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 90;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(793, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Room Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 91);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Property Longitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(740, 59);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Property Lattitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(667, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Number of Host Properties:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 85;
            this.label4.Text = "Host Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(88, 102);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 20);
            this.label24.TabIndex = 84;
            this.label24.Text = "Host ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(23, 63);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 20);
            this.label25.TabIndex = 83;
            this.label25.Text = "Property Name:";
            // 
            // txtAvailableDays
            // 
            this.txtAvailableDays.Location = new System.Drawing.Point(1409, 91);
            this.txtAvailableDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtAvailableDays.Name = "txtAvailableDays";
            this.txtAvailableDays.Size = new System.Drawing.Size(59, 26);
            this.txtAvailableDays.TabIndex = 82;
            // 
            // txtPropName
            // 
            this.txtPropName.Location = new System.Drawing.Point(173, 63);
            this.txtPropName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(472, 26);
            this.txtPropName.TabIndex = 81;
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(173, 98);
            this.txtHostID.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(132, 26);
            this.txtHostID.TabIndex = 80;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(173, 134);
            this.txtHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(293, 26);
            this.txtHostName.TabIndex = 79;
            // 
            // txtHostNumProp
            // 
            this.txtHostNumProp.Location = new System.Drawing.Point(915, 27);
            this.txtHostNumProp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHostNumProp.Name = "txtHostNumProp";
            this.txtHostNumProp.Size = new System.Drawing.Size(59, 26);
            this.txtHostNumProp.TabIndex = 78;
            // 
            // txtLattitude
            // 
            this.txtLattitude.Location = new System.Drawing.Point(915, 59);
            this.txtLattitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLattitude.Name = "txtLattitude";
            this.txtLattitude.Size = new System.Drawing.Size(132, 26);
            this.txtLattitude.TabIndex = 77;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(915, 91);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(4);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(132, 26);
            this.txtLongitude.TabIndex = 76;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(915, 123);
            this.txtRoomType.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(204, 26);
            this.txtRoomType.TabIndex = 75;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1409, 27);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 26);
            this.txtPrice.TabIndex = 74;
            // 
            // txtMinNumNights
            // 
            this.txtMinNumNights.Location = new System.Drawing.Point(1409, 59);
            this.txtMinNumNights.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinNumNights.Name = "txtMinNumNights";
            this.txtMinNumNights.Size = new System.Drawing.Size(59, 26);
            this.txtMinNumNights.TabIndex = 73;
            // 
            // txtPropID
            // 
            this.txtPropID.Location = new System.Drawing.Point(173, 27);
            this.txtPropID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(293, 26);
            this.txtPropID.TabIndex = 72;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(205, 176);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(118, 20);
            this.label26.TabIndex = 105;
            this.label26.Text = "District Name:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(341, 178);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(175, 20);
            this.label27.TabIndex = 106;
            this.label27.Text = "Neighbourhood Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPropDelConfirm);
            this.groupBox1.Controls.Add(this.btnPropCancel);
            this.groupBox1.Controls.Add(this.btnEditPropSave);
            this.groupBox1.Controls.Add(this.btnAddPropSave);
            this.groupBox1.Controls.Add(this.dgdProperty);
            this.groupBox1.Controls.Add(this.btnDeleteProperty);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.txtAvailableDays);
            this.groupBox1.Controls.Add(this.txtPropName);
            this.groupBox1.Controls.Add(this.txtHostID);
            this.groupBox1.Controls.Add(this.txtHostName);
            this.groupBox1.Controls.Add(this.txtHostNumProp);
            this.groupBox1.Controls.Add(this.txtLattitude);
            this.groupBox1.Controls.Add(this.txtLongitude);
            this.groupBox1.Controls.Add(this.txtRoomType);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtMinNumNights);
            this.groupBox1.Controls.Add(this.txtPropID);
            this.groupBox1.Controls.Add(this.btnEditProp);
            this.groupBox1.Controls.Add(this.btnAddProperty);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(2025, 551);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Details";
            // 
            // btnPropDelConfirm
            // 
            this.btnPropDelConfirm.Location = new System.Drawing.Point(1543, 142);
            this.btnPropDelConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnPropDelConfirm.Name = "btnPropDelConfirm";
            this.btnPropDelConfirm.Size = new System.Drawing.Size(227, 30);
            this.btnPropDelConfirm.TabIndex = 113;
            this.btnPropDelConfirm.Text = "Confirm Delete";
            this.btnPropDelConfirm.UseVisualStyleBackColor = true;
            this.btnPropDelConfirm.Visible = false;
            this.btnPropDelConfirm.Click += new System.EventHandler(this.BtnPropDelConfirm_Click);
            // 
            // btnPropCancel
            // 
            this.btnPropCancel.Location = new System.Drawing.Point(1777, 26);
            this.btnPropCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPropCancel.Name = "btnPropCancel";
            this.btnPropCancel.Size = new System.Drawing.Size(227, 30);
            this.btnPropCancel.TabIndex = 112;
            this.btnPropCancel.Text = "Cancel";
            this.btnPropCancel.UseVisualStyleBackColor = true;
            this.btnPropCancel.Visible = false;
            this.btnPropCancel.Click += new System.EventHandler(this.BtnPropCancel_Click);
            // 
            // btnEditPropSave
            // 
            this.btnEditPropSave.Location = new System.Drawing.Point(1543, 103);
            this.btnEditPropSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditPropSave.Name = "btnEditPropSave";
            this.btnEditPropSave.Size = new System.Drawing.Size(227, 30);
            this.btnEditPropSave.TabIndex = 109;
            this.btnEditPropSave.Text = "Save Edited Property";
            this.btnEditPropSave.UseVisualStyleBackColor = true;
            this.btnEditPropSave.Visible = false;
            this.btnEditPropSave.Click += new System.EventHandler(this.BtnEditPropSave_Click);
            // 
            // btnAddPropSave
            // 
            this.btnAddPropSave.Location = new System.Drawing.Point(1543, 65);
            this.btnAddPropSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddPropSave.Name = "btnAddPropSave";
            this.btnAddPropSave.Size = new System.Drawing.Size(227, 30);
            this.btnAddPropSave.TabIndex = 108;
            this.btnAddPropSave.Text = "Save New Property";
            this.btnAddPropSave.UseVisualStyleBackColor = true;
            this.btnAddPropSave.Visible = false;
            this.btnAddPropSave.Click += new System.EventHandler(this.BtnAddPropSave_Click);
            // 
            // dgdProperty
            // 
            this.dgdProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProperty.Location = new System.Drawing.Point(29, 224);
            this.dgdProperty.Margin = new System.Windows.Forms.Padding(4);
            this.dgdProperty.Name = "dgdProperty";
            this.dgdProperty.RowHeadersWidth = 10;
            this.dgdProperty.RowTemplate.Height = 18;
            this.dgdProperty.Size = new System.Drawing.Size(1975, 320);
            this.dgdProperty.TabIndex = 107;
            this.dgdProperty.SelectionChanged += new System.EventHandler(this.DgdProperty_SelectionChanged);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(1777, 142);
            this.btnDeleteProperty.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(227, 30);
            this.btnDeleteProperty.TabIndex = 105;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.BtnDeleteProperty_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNeighCancel);
            this.groupBox2.Controls.Add(this.btnEditNeighSave);
            this.groupBox2.Controls.Add(this.btnNeighAddSave);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumProperties);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtNeighbourhoodName);
            this.groupBox2.Controls.Add(this.lstNeighbourhood);
            this.groupBox2.Controls.Add(this.btnEditNeigh);
            this.groupBox2.Controls.Add(this.btnAddNeighbourhood);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(957, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1095, 266);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbourhood Details:";
            // 
            // btnNeighCancel
            // 
            this.btnNeighCancel.Location = new System.Drawing.Point(846, 142);
            this.btnNeighCancel.Name = "btnNeighCancel";
            this.btnNeighCancel.Size = new System.Drawing.Size(230, 30);
            this.btnNeighCancel.TabIndex = 112;
            this.btnNeighCancel.Text = "Cancel";
            this.btnNeighCancel.UseVisualStyleBackColor = true;
            this.btnNeighCancel.Visible = false;
            this.btnNeighCancel.Click += new System.EventHandler(this.BtnNeighCancel_Click);
            // 
            // btnEditNeighSave
            // 
            this.btnEditNeighSave.Location = new System.Drawing.Point(846, 214);
            this.btnEditNeighSave.Name = "btnEditNeighSave";
            this.btnEditNeighSave.Size = new System.Drawing.Size(230, 30);
            this.btnEditNeighSave.TabIndex = 111;
            this.btnEditNeighSave.Text = "Save Edited Neighbourhood";
            this.btnEditNeighSave.UseVisualStyleBackColor = true;
            this.btnEditNeighSave.Visible = false;
            this.btnEditNeighSave.Click += new System.EventHandler(this.BtnEditNeighSave_Click);
            // 
            // btnNeighAddSave
            // 
            this.btnNeighAddSave.Location = new System.Drawing.Point(846, 178);
            this.btnNeighAddSave.Name = "btnNeighAddSave";
            this.btnNeighAddSave.Size = new System.Drawing.Size(230, 30);
            this.btnNeighAddSave.TabIndex = 110;
            this.btnNeighAddSave.Text = "Save New Neighbourhood";
            this.btnNeighAddSave.UseVisualStyleBackColor = true;
            this.btnNeighAddSave.Visible = false;
            this.btnNeighAddSave.Click += new System.EventHandler(this.BtnNeighAddSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "# of Properties in Neighbourhood:";
            // 
            // txtNumProperties
            // 
            this.txtNumProperties.Location = new System.Drawing.Point(564, 212);
            this.txtNumProperties.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumProperties.Name = "txtNumProperties";
            this.txtNumProperties.Size = new System.Drawing.Size(39, 26);
            this.txtNumProperties.TabIndex = 108;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDistrictSearch);
            this.groupBox3.Controls.Add(this.btnDistCancel);
            this.groupBox3.Controls.Add(this.btnEditDistSave);
            this.groupBox3.Controls.Add(this.btnDistAddSave);
            this.groupBox3.Controls.Add(this.TxtDistrictSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNumNeighbourhoods);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtDistrictName);
            this.groupBox3.Controls.Add(this.btnEditDist);
            this.groupBox3.Controls.Add(this.lstDistrict);
            this.groupBox3.Controls.Add(this.btnAddDistrict);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(19, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(931, 266);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "District Details:";
            // 
            // btnDistCancel
            // 
            this.btnDistCancel.Location = new System.Drawing.Point(679, 140);
            this.btnDistCancel.Name = "btnDistCancel";
            this.btnDistCancel.Size = new System.Drawing.Size(227, 30);
            this.btnDistCancel.TabIndex = 113;
            this.btnDistCancel.Text = "Cancel";
            this.btnDistCancel.UseVisualStyleBackColor = true;
            this.btnDistCancel.Visible = false;
            this.btnDistCancel.Click += new System.EventHandler(this.BtnDistCancel_Click);
            // 
            // btnEditDistSave
            // 
            this.btnEditDistSave.Location = new System.Drawing.Point(679, 212);
            this.btnEditDistSave.Name = "btnEditDistSave";
            this.btnEditDistSave.Size = new System.Drawing.Size(227, 30);
            this.btnEditDistSave.TabIndex = 112;
            this.btnEditDistSave.Text = "Save Edited District";
            this.btnEditDistSave.UseVisualStyleBackColor = true;
            this.btnEditDistSave.Visible = false;
            this.btnEditDistSave.Click += new System.EventHandler(this.BtnEditDistSave_Click);
            // 
            // btnDistAddSave
            // 
            this.btnDistAddSave.Location = new System.Drawing.Point(679, 176);
            this.btnDistAddSave.Name = "btnDistAddSave";
            this.btnDistAddSave.Size = new System.Drawing.Size(227, 30);
            this.btnDistAddSave.TabIndex = 111;
            this.btnDistAddSave.Text = "Save New District";
            this.btnDistAddSave.UseVisualStyleBackColor = true;
            this.btnDistAddSave.Visible = false;
            this.btnDistAddSave.Click += new System.EventHandler(this.BtnDistAddSave_Click);
            // 
            // TxtDistrictSearch
            // 
            this.TxtDistrictSearch.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.TxtDistrictSearch.Location = new System.Drawing.Point(13, 35);
            this.TxtDistrictSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDistrictSearch.Name = "TxtDistrictSearch";
            this.TxtDistrictSearch.Size = new System.Drawing.Size(181, 26);
            this.TxtDistrictSearch.TabIndex = 109;
            this.TxtDistrictSearch.Text = "Type Here to search";
            this.TxtDistrictSearch.Click += new System.EventHandler(this.TxtDistrictSearch_Click);
            this.TxtDistrictSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDistrictSearch_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "# Neighbourhoods in District:";
            // 
            // txtNumNeighbourhoods
            // 
            this.txtNumNeighbourhoods.Location = new System.Drawing.Point(376, 212);
            this.txtNumNeighbourhoods.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumNeighbourhoods.Name = "txtNumNeighbourhoods";
            this.txtNumNeighbourhoods.Size = new System.Drawing.Size(59, 26);
            this.txtNumNeighbourhoods.TabIndex = 107;
            // 
            // lblDistrictSearch
            // 
            this.lblDistrictSearch.AutoSize = true;
            this.lblDistrictSearch.Location = new System.Drawing.Point(205, 38);
            this.lblDistrictSearch.Name = "lblDistrictSearch";
            this.lblDistrictSearch.Size = new System.Drawing.Size(78, 25);
            this.lblDistrictSearch.TabIndex = 114;
            this.lblDistrictSearch.Text = "Search";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2087, 967);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShow);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProperty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnAddNeighbourhood;
        private System.Windows.Forms.Button btnAddDistrict;
        private System.Windows.Forms.ListBox lstDistrict;
        private System.Windows.Forms.Button btnEditProp;
        private System.Windows.Forms.Button btnEditNeigh;
        private System.Windows.Forms.Button btnEditDist;
        private System.Windows.Forms.ListBox lstNeighbourhood;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDistrictName;
        private System.Windows.Forms.TextBox txtNeighbourhoodName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtAvailableDays;
        private System.Windows.Forms.TextBox txtPropName;
        private System.Windows.Forms.TextBox txtHostID;
        private System.Windows.Forms.TextBox txtHostName;
        private System.Windows.Forms.TextBox txtHostNumProp;
        private System.Windows.Forms.TextBox txtLattitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMinNumNights;
        private System.Windows.Forms.TextBox txtPropID;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumNeighbourhoods;
        private System.Windows.Forms.DataGridView dgdProperty;
        private System.Windows.Forms.TextBox TxtDistrictSearch;
        private System.Windows.Forms.Button btnEditPropSave;
        private System.Windows.Forms.Button btnAddPropSave;
        private System.Windows.Forms.Button btnPropCancel;
        private System.Windows.Forms.Button btnPropDelConfirm;
        private System.Windows.Forms.Button btnEditNeighSave;
        private System.Windows.Forms.Button btnNeighAddSave;
        private System.Windows.Forms.Button btnEditDistSave;
        private System.Windows.Forms.Button btnDistAddSave;
        private System.Windows.Forms.Button btnDistCancel;
        private System.Windows.Forms.Button btnNeighCancel;
        private System.Windows.Forms.Label lblDistrictSearch;
    }
}

