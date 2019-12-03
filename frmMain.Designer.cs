namespace Assignment_form
{
    partial class frmMain
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
            this.dgdProperty = new System.Windows.Forms.DataGridView();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.btnClearProperty = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumProperties = new System.Windows.Forms.TextBox();
            this.btnDeleteNeigh = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumNeighbourhoods = new System.Windows.Forms.TextBox();
            this.btnDeleteDist = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdProperty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Location = new System.Drawing.Point(1465, 40);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(170, 25);
            this.btnAddProperty.TabIndex = 3;
            this.btnAddProperty.Text = "Add Property";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.BtnAddProperty_Click);
            // 
            // btnAddNeighbourhood
            // 
            this.btnAddNeighbourhood.Location = new System.Drawing.Point(696, 22);
            this.btnAddNeighbourhood.Name = "btnAddNeighbourhood";
            this.btnAddNeighbourhood.Size = new System.Drawing.Size(170, 25);
            this.btnAddNeighbourhood.TabIndex = 4;
            this.btnAddNeighbourhood.Text = "Add Neighbourhood";
            this.btnAddNeighbourhood.UseVisualStyleBackColor = true;
            this.btnAddNeighbourhood.Click += new System.EventHandler(this.BtnAddNeighbourhood_Click);
            // 
            // btnAddDistrict
            // 
            this.btnAddDistrict.Location = new System.Drawing.Point(577, 20);
            this.btnAddDistrict.Name = "btnAddDistrict";
            this.btnAddDistrict.Size = new System.Drawing.Size(170, 25);
            this.btnAddDistrict.TabIndex = 5;
            this.btnAddDistrict.Text = "Add District";
            this.btnAddDistrict.UseVisualStyleBackColor = true;
            this.btnAddDistrict.Click += new System.EventHandler(this.BtnAddDistrict_Click);
            // 
            // lstDistrict
            // 
            this.lstDistrict.FormattingEnabled = true;
            this.lstDistrict.ItemHeight = 16;
            this.lstDistrict.Location = new System.Drawing.Point(23, 29);
            this.lstDistrict.Margin = new System.Windows.Forms.Padding(5);
            this.lstDistrict.Name = "lstDistrict";
            this.lstDistrict.Size = new System.Drawing.Size(137, 132);
            this.lstDistrict.TabIndex = 6;
            this.lstDistrict.SelectedIndexChanged += new System.EventHandler(this.LstDistrict_SelectedIndexChanged);
            // 
            // btnEditProp
            // 
            this.btnEditProp.Location = new System.Drawing.Point(1465, 71);
            this.btnEditProp.Name = "btnEditProp";
            this.btnEditProp.Size = new System.Drawing.Size(170, 25);
            this.btnEditProp.TabIndex = 7;
            this.btnEditProp.Text = "Edit Property";
            this.btnEditProp.UseVisualStyleBackColor = true;
            this.btnEditProp.Click += new System.EventHandler(this.BtnEditProp_Click);
            // 
            // btnEditNeigh
            // 
            this.btnEditNeigh.Location = new System.Drawing.Point(696, 53);
            this.btnEditNeigh.Name = "btnEditNeigh";
            this.btnEditNeigh.Size = new System.Drawing.Size(170, 25);
            this.btnEditNeigh.TabIndex = 8;
            this.btnEditNeigh.Text = "Edit Neighbourhood";
            this.btnEditNeigh.UseVisualStyleBackColor = true;
            this.btnEditNeigh.Click += new System.EventHandler(this.BtnEditNeigh_Click);
            // 
            // btnEditDist
            // 
            this.btnEditDist.Location = new System.Drawing.Point(577, 51);
            this.btnEditDist.Name = "btnEditDist";
            this.btnEditDist.Size = new System.Drawing.Size(170, 25);
            this.btnEditDist.TabIndex = 9;
            this.btnEditDist.Text = "Edit District";
            this.btnEditDist.UseVisualStyleBackColor = true;
            this.btnEditDist.Click += new System.EventHandler(this.BtnEditDist_Click);
            // 
            // lstNeighbourhood
            // 
            this.lstNeighbourhood.FormattingEnabled = true;
            this.lstNeighbourhood.ItemHeight = 16;
            this.lstNeighbourhood.Location = new System.Drawing.Point(22, 22);
            this.lstNeighbourhood.Margin = new System.Windows.Forms.Padding(5);
            this.lstNeighbourhood.Name = "lstNeighbourhood";
            this.lstNeighbourhood.Size = new System.Drawing.Size(222, 164);
            this.lstNeighbourhood.TabIndex = 11;
            this.lstNeighbourhood.SelectedIndexChanged += new System.EventHandler(this.LstNeighbourhood_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(160, 775);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(130, 40);
            this.btnShow.TabIndex = 13;
            this.btnShow.Text = "Show Details";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(24, 775);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(130, 40);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Load data File";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1669, 771);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 41);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // txtDistrictName
            // 
            this.txtDistrictName.Location = new System.Drawing.Point(282, 31);
            this.txtDistrictName.Name = "txtDistrictName";
            this.txtDistrictName.Size = new System.Drawing.Size(209, 23);
            this.txtDistrictName.TabIndex = 19;
            // 
            // txtNeighbourhoodName
            // 
            this.txtNeighbourhoodName.Location = new System.Drawing.Point(420, 22);
            this.txtNeighbourhoodName.Name = "txtNeighbourhoodName";
            this.txtNeighbourhoodName.Size = new System.Drawing.Size(209, 23);
            this.txtNeighbourhoodName.TabIndex = 20;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(353, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 17);
            this.label23.TabIndex = 104;
            this.label23.Text = "*";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(491, 51);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(13, 17);
            this.label22.TabIndex = 103;
            this.label22.Text = "*";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(236, 80);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(13, 17);
            this.label21.TabIndex = 102;
            this.label21.Text = "*";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(357, 109);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 101;
            this.label20.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(757, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 17);
            this.label19.TabIndex = 100;
            this.label19.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1139, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 17);
            this.label18.TabIndex = 99;
            this.label18.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1139, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 17);
            this.label17.TabIndex = 98;
            this.label17.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1194, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 17);
            this.label16.TabIndex = 97;
            this.label16.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(866, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 96;
            this.label15.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(812, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 95;
            this.label14.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(813, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 93;
            this.label13.Text = "Property ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(898, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 17);
            this.label11.TabIndex = 92;
            this.label11.Text = "Availability (Days Per Year):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(901, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 17);
            this.label10.TabIndex = 91;
            this.label10.Text = "Minimum Number of Nights:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1038, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 90;
            this.label9.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 17);
            this.label8.TabIndex = 89;
            this.label8.Text = "Room Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(567, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 17);
            this.label7.TabIndex = 88;
            this.label7.Text = "Property Longitude:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(575, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 17);
            this.label6.TabIndex = 87;
            this.label6.Text = "Property Lattitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Number of Host Properties:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 85;
            this.label4.Text = "Host Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(66, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 17);
            this.label24.TabIndex = 84;
            this.label24.Text = "Host ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 51);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(107, 17);
            this.label25.TabIndex = 83;
            this.label25.Text = "Property Name:";
            // 
            // txtAvailableDays
            // 
            this.txtAvailableDays.Location = new System.Drawing.Point(1088, 74);
            this.txtAvailableDays.Name = "txtAvailableDays";
            this.txtAvailableDays.Size = new System.Drawing.Size(45, 23);
            this.txtAvailableDays.TabIndex = 82;
            // 
            // txtPropName
            // 
            this.txtPropName.Location = new System.Drawing.Point(130, 51);
            this.txtPropName.Name = "txtPropName";
            this.txtPropName.Size = new System.Drawing.Size(355, 23);
            this.txtPropName.TabIndex = 81;
            // 
            // txtHostID
            // 
            this.txtHostID.Location = new System.Drawing.Point(130, 80);
            this.txtHostID.Name = "txtHostID";
            this.txtHostID.Size = new System.Drawing.Size(100, 23);
            this.txtHostID.TabIndex = 80;
            // 
            // txtHostName
            // 
            this.txtHostName.Location = new System.Drawing.Point(130, 109);
            this.txtHostName.Name = "txtHostName";
            this.txtHostName.Size = new System.Drawing.Size(221, 23);
            this.txtHostName.TabIndex = 79;
            // 
            // txtHostNumProp
            // 
            this.txtHostNumProp.Location = new System.Drawing.Point(706, 25);
            this.txtHostNumProp.Name = "txtHostNumProp";
            this.txtHostNumProp.Size = new System.Drawing.Size(45, 23);
            this.txtHostNumProp.TabIndex = 78;
            // 
            // txtLattitude
            // 
            this.txtLattitude.Location = new System.Drawing.Point(706, 51);
            this.txtLattitude.Name = "txtLattitude";
            this.txtLattitude.Size = new System.Drawing.Size(100, 23);
            this.txtLattitude.TabIndex = 77;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(706, 77);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 23);
            this.txtLongitude.TabIndex = 76;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(706, 103);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(154, 23);
            this.txtRoomType.TabIndex = 75;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(1088, 22);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 74;
            // 
            // txtMinNumNights
            // 
            this.txtMinNumNights.Location = new System.Drawing.Point(1088, 48);
            this.txtMinNumNights.Name = "txtMinNumNights";
            this.txtMinNumNights.Size = new System.Drawing.Size(45, 23);
            this.txtMinNumNights.TabIndex = 73;
            // 
            // txtPropID
            // 
            this.txtPropID.Location = new System.Drawing.Point(130, 22);
            this.txtPropID.Name = "txtPropID";
            this.txtPropID.Size = new System.Drawing.Size(221, 23);
            this.txtPropID.TabIndex = 72;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(180, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 17);
            this.label26.TabIndex = 105;
            this.label26.Text = "District Name:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(263, 26);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(151, 17);
            this.label27.TabIndex = 106;
            this.label27.Text = "Neighbourhood Name:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(20, 274);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1676, 475);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Details";
            // 
            // dgdProperty
            // 
            this.dgdProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdProperty.Location = new System.Drawing.Point(22, 164);
            this.dgdProperty.Name = "dgdProperty";
            this.dgdProperty.RowHeadersWidth = 10;
            this.dgdProperty.RowTemplate.Height = 18;
            this.dgdProperty.Size = new System.Drawing.Size(1613, 290);
            this.dgdProperty.TabIndex = 107;
            this.dgdProperty.SelectionChanged += new System.EventHandler(this.DgdProperty_SelectionChanged);
            // 
            // btnDeleteProperty
            // 
            this.btnDeleteProperty.Location = new System.Drawing.Point(1465, 102);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(170, 25);
            this.btnDeleteProperty.TabIndex = 105;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = true;
            this.btnDeleteProperty.Click += new System.EventHandler(this.BtnDeleteProperty_Click);
            // 
            // btnClearProperty
            // 
            this.btnClearProperty.Location = new System.Drawing.Point(296, 775);
            this.btnClearProperty.Name = "btnClearProperty";
            this.btnClearProperty.Size = new System.Drawing.Size(130, 40);
            this.btnClearProperty.TabIndex = 106;
            this.btnClearProperty.Text = "Clear Form";
            this.btnClearProperty.UseVisualStyleBackColor = true;
            this.btnClearProperty.Click += new System.EventHandler(this.BtnClearProperty_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNumProperties);
            this.groupBox2.Controls.Add(this.btnDeleteNeigh);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.txtNeighbourhoodName);
            this.groupBox2.Controls.Add(this.lstNeighbourhood);
            this.groupBox2.Controls.Add(this.btnEditNeigh);
            this.groupBox2.Controls.Add(this.btnAddNeighbourhood);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(789, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 216);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Neighbourhood Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 17);
            this.label2.TabIndex = 109;
            this.label2.Text = "# of Properties in Neighbourhood:";
            // 
            // txtNumProperties
            // 
            this.txtNumProperties.Location = new System.Drawing.Point(584, 51);
            this.txtNumProperties.Name = "txtNumProperties";
            this.txtNumProperties.Size = new System.Drawing.Size(45, 23);
            this.txtNumProperties.TabIndex = 108;
            // 
            // btnDeleteNeigh
            // 
            this.btnDeleteNeigh.Location = new System.Drawing.Point(696, 84);
            this.btnDeleteNeigh.Name = "btnDeleteNeigh";
            this.btnDeleteNeigh.Size = new System.Drawing.Size(170, 25);
            this.btnDeleteNeigh.TabIndex = 107;
            this.btnDeleteNeigh.Text = "Delete Neighbourhood";
            this.btnDeleteNeigh.UseVisualStyleBackColor = true;
            this.btnDeleteNeigh.Click += new System.EventHandler(this.BtnDeleteNeigh_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtNumNeighbourhoods);
            this.groupBox3.Controls.Add(this.btnDeleteDist);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.txtDistrictName);
            this.groupBox3.Controls.Add(this.btnEditDist);
            this.groupBox3.Controls.Add(this.lstDistrict);
            this.groupBox3.Controls.Add(this.btnAddDistrict);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(769, 216);
            this.groupBox3.TabIndex = 109;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "District Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 108;
            this.label1.Text = "# Neighbourhoods in District:";
            // 
            // txtNumNeighbourhoods
            // 
            this.txtNumNeighbourhoods.Location = new System.Drawing.Point(446, 60);
            this.txtNumNeighbourhoods.Name = "txtNumNeighbourhoods";
            this.txtNumNeighbourhoods.Size = new System.Drawing.Size(45, 23);
            this.txtNumNeighbourhoods.TabIndex = 107;
            // 
            // btnDeleteDist
            // 
            this.btnDeleteDist.Location = new System.Drawing.Point(577, 82);
            this.btnDeleteDist.Name = "btnDeleteDist";
            this.btnDeleteDist.Size = new System.Drawing.Size(170, 25);
            this.btnDeleteDist.TabIndex = 106;
            this.btnDeleteDist.Text = "Delete District";
            this.btnDeleteDist.UseVisualStyleBackColor = true;
            this.btnDeleteDist.Click += new System.EventHandler(this.BtnDeleteDist_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1811, 824);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClearProperty);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnShow);
            this.Name = "frmMain";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
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
        private System.Windows.Forms.Button btnDeleteDist;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Button btnDeleteNeigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumProperties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumNeighbourhoods;
        private System.Windows.Forms.Button btnClearProperty;
        private System.Windows.Forms.DataGridView dgdProperty;
    }
}

