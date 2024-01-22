namespace AirBNB.View
{
    partial class UserControl_AddRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_regRoomContainer = new System.Windows.Forms.Panel();
            this.checkBox_addRoomShrdRoom = new System.Windows.Forms.CheckBox();
            this.checkBox_addRoomPrvtRoom = new System.Windows.Forms.CheckBox();
            this.checkBox_addRoomEntirePlace = new System.Windows.Forms.CheckBox();
            this.comboBox_addRoomGuestCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_addRoomPrice = new System.Windows.Forms.TextBox();
            this.textBox_pesoSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_addNumRooms = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_addRoomID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_addThirdImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_addSecondImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_addFirstImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_addRoomAmenities = new System.Windows.Forms.RichTextBox();
            this.button_ownerMenuAddRoom = new System.Windows.Forms.Button();
            this.comboBox_addRoomLocation = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_addRoomAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_Status = new System.Windows.Forms.Panel();
            this.comboBox_addRoomAvailability = new System.Windows.Forms.ComboBox();
            this.panel_regRoomContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addThirdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addSecondImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFirstImage)).BeginInit();
            this.panel_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_regRoomContainer
            // 
            this.panel_regRoomContainer.Controls.Add(this.checkBox_addRoomShrdRoom);
            this.panel_regRoomContainer.Controls.Add(this.checkBox_addRoomPrvtRoom);
            this.panel_regRoomContainer.Controls.Add(this.checkBox_addRoomEntirePlace);
            this.panel_regRoomContainer.Location = new System.Drawing.Point(3, 3);
            this.panel_regRoomContainer.Name = "panel_regRoomContainer";
            this.panel_regRoomContainer.Size = new System.Drawing.Size(120, 131);
            this.panel_regRoomContainer.TabIndex = 21;
            // 
            // checkBox_addRoomShrdRoom
            // 
            this.checkBox_addRoomShrdRoom.AutoSize = true;
            this.checkBox_addRoomShrdRoom.FlatAppearance.BorderSize = 0;
            this.checkBox_addRoomShrdRoom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_addRoomShrdRoom.Location = new System.Drawing.Point(4, 97);
            this.checkBox_addRoomShrdRoom.Name = "checkBox_addRoomShrdRoom";
            this.checkBox_addRoomShrdRoom.Size = new System.Drawing.Size(113, 22);
            this.checkBox_addRoomShrdRoom.TabIndex = 2;
            this.checkBox_addRoomShrdRoom.Text = "Shared Room";
            this.checkBox_addRoomShrdRoom.UseVisualStyleBackColor = true;
            this.checkBox_addRoomShrdRoom.CheckedChanged += new System.EventHandler(this.checkBox_addRoomShrdRoom_CheckedChanged);
            // 
            // checkBox_addRoomPrvtRoom
            // 
            this.checkBox_addRoomPrvtRoom.AutoSize = true;
            this.checkBox_addRoomPrvtRoom.FlatAppearance.BorderSize = 0;
            this.checkBox_addRoomPrvtRoom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_addRoomPrvtRoom.Location = new System.Drawing.Point(4, 51);
            this.checkBox_addRoomPrvtRoom.Name = "checkBox_addRoomPrvtRoom";
            this.checkBox_addRoomPrvtRoom.Size = new System.Drawing.Size(112, 22);
            this.checkBox_addRoomPrvtRoom.TabIndex = 1;
            this.checkBox_addRoomPrvtRoom.Text = "Private Room";
            this.checkBox_addRoomPrvtRoom.UseVisualStyleBackColor = true;
            this.checkBox_addRoomPrvtRoom.CheckedChanged += new System.EventHandler(this.checkBox_addRoomPrvtRoom_CheckedChanged);
            // 
            // checkBox_addRoomEntirePlace
            // 
            this.checkBox_addRoomEntirePlace.AutoSize = true;
            this.checkBox_addRoomEntirePlace.FlatAppearance.BorderSize = 0;
            this.checkBox_addRoomEntirePlace.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_addRoomEntirePlace.Location = new System.Drawing.Point(4, 12);
            this.checkBox_addRoomEntirePlace.Name = "checkBox_addRoomEntirePlace";
            this.checkBox_addRoomEntirePlace.Size = new System.Drawing.Size(101, 22);
            this.checkBox_addRoomEntirePlace.TabIndex = 0;
            this.checkBox_addRoomEntirePlace.Text = "Entire Place";
            this.checkBox_addRoomEntirePlace.UseVisualStyleBackColor = true;
            this.checkBox_addRoomEntirePlace.CheckedChanged += new System.EventHandler(this.checkBox_addRoomEntirePlace_CheckedChanged);
            // 
            // comboBox_addRoomGuestCap
            // 
            this.comboBox_addRoomGuestCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_addRoomGuestCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addRoomGuestCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_addRoomGuestCap.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addRoomGuestCap.FormattingEnabled = true;
            this.comboBox_addRoomGuestCap.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_addRoomGuestCap.Location = new System.Drawing.Point(281, 44);
            this.comboBox_addRoomGuestCap.Name = "comboBox_addRoomGuestCap";
            this.comboBox_addRoomGuestCap.Size = new System.Drawing.Size(74, 25);
            this.comboBox_addRoomGuestCap.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(170, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Guest Capacity:";
            // 
            // textBox_addRoomPrice
            // 
            this.textBox_addRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_addRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_addRoomPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addRoomPrice.Location = new System.Drawing.Point(281, 15);
            this.textBox_addRoomPrice.Name = "textBox_addRoomPrice";
            this.textBox_addRoomPrice.Size = new System.Drawing.Size(114, 24);
            this.textBox_addRoomPrice.TabIndex = 32;
            // 
            // textBox_pesoSign
            // 
            this.textBox_pesoSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_pesoSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pesoSign.Enabled = false;
            this.textBox_pesoSign.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pesoSign.Location = new System.Drawing.Point(268, 17);
            this.textBox_pesoSign.Name = "textBox_pesoSign";
            this.textBox_pesoSign.ReadOnly = true;
            this.textBox_pesoSign.Size = new System.Drawing.Size(13, 17);
            this.textBox_pesoSign.TabIndex = 31;
            this.textBox_pesoSign.Text = "₱";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Price:";
            // 
            // comboBox_addNumRooms
            // 
            this.comboBox_addNumRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_addNumRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addNumRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_addNumRooms.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addNumRooms.FormattingEnabled = true;
            this.comboBox_addNumRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5\t"});
            this.comboBox_addNumRooms.Location = new System.Drawing.Point(281, 78);
            this.comboBox_addNumRooms.Name = "comboBox_addNumRooms";
            this.comboBox_addNumRooms.Size = new System.Drawing.Size(74, 25);
            this.comboBox_addNumRooms.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Number of Bedrooms:";
            // 
            // textBox_addRoomID
            // 
            this.textBox_addRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_addRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_addRoomID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addRoomID.Location = new System.Drawing.Point(511, 15);
            this.textBox_addRoomID.Name = "textBox_addRoomID";
            this.textBox_addRoomID.ReadOnly = true;
            this.textBox_addRoomID.Size = new System.Drawing.Size(149, 21);
            this.textBox_addRoomID.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Room ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Double Click Boxes to Enter Images";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox_addThirdImage);
            this.panel1.Controls.Add(this.pictureBox_addSecondImage);
            this.panel1.Controls.Add(this.pictureBox_addFirstImage);
            this.panel1.Location = new System.Drawing.Point(330, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 265);
            this.panel1.TabIndex = 42;
            // 
            // pictureBox_addThirdImage
            // 
            this.pictureBox_addThirdImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_addThirdImage.Location = new System.Drawing.Point(92, 134);
            this.pictureBox_addThirdImage.Name = "pictureBox_addThirdImage";
            this.pictureBox_addThirdImage.Size = new System.Drawing.Size(150, 120);
            this.pictureBox_addThirdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_addThirdImage.TabIndex = 28;
            this.pictureBox_addThirdImage.TabStop = false;
            this.pictureBox_addThirdImage.DoubleClick += new System.EventHandler(this.pictureBox_addThirdImage_DoubleClick);
            // 
            // pictureBox_addSecondImage
            // 
            this.pictureBox_addSecondImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_addSecondImage.Location = new System.Drawing.Point(166, 8);
            this.pictureBox_addSecondImage.Name = "pictureBox_addSecondImage";
            this.pictureBox_addSecondImage.Size = new System.Drawing.Size(150, 120);
            this.pictureBox_addSecondImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_addSecondImage.TabIndex = 28;
            this.pictureBox_addSecondImage.TabStop = false;
            this.pictureBox_addSecondImage.DoubleClick += new System.EventHandler(this.pictureBox_addSecondImage_DoubleClick);
            // 
            // pictureBox_addFirstImage
            // 
            this.pictureBox_addFirstImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_addFirstImage.Location = new System.Drawing.Point(10, 8);
            this.pictureBox_addFirstImage.Name = "pictureBox_addFirstImage";
            this.pictureBox_addFirstImage.Size = new System.Drawing.Size(150, 120);
            this.pictureBox_addFirstImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_addFirstImage.TabIndex = 24;
            this.pictureBox_addFirstImage.TabStop = false;
            this.pictureBox_addFirstImage.DoubleClick += new System.EventHandler(this.pictureBox_addFirstImage_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Amenities:";
            // 
            // richTextBox_addRoomAmenities
            // 
            this.richTextBox_addRoomAmenities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.richTextBox_addRoomAmenities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_addRoomAmenities.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_addRoomAmenities.Location = new System.Drawing.Point(91, 192);
            this.richTextBox_addRoomAmenities.Name = "richTextBox_addRoomAmenities";
            this.richTextBox_addRoomAmenities.Size = new System.Drawing.Size(202, 156);
            this.richTextBox_addRoomAmenities.TabIndex = 40;
            this.richTextBox_addRoomAmenities.Text = "";
            // 
            // button_ownerMenuAddRoom
            // 
            this.button_ownerMenuAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.button_ownerMenuAddRoom.FlatAppearance.BorderSize = 0;
            this.button_ownerMenuAddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ownerMenuAddRoom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ownerMenuAddRoom.Location = new System.Drawing.Point(129, 400);
            this.button_ownerMenuAddRoom.Name = "button_ownerMenuAddRoom";
            this.button_ownerMenuAddRoom.Size = new System.Drawing.Size(112, 52);
            this.button_ownerMenuAddRoom.TabIndex = 45;
            this.button_ownerMenuAddRoom.Text = "Submit";
            this.button_ownerMenuAddRoom.UseVisualStyleBackColor = false;
            this.button_ownerMenuAddRoom.Click += new System.EventHandler(this.button_ownerMenuAddRoom_Click);
            // 
            // comboBox_addRoomLocation
            // 
            this.comboBox_addRoomLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_addRoomLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addRoomLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_addRoomLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addRoomLocation.FormattingEnabled = true;
            this.comboBox_addRoomLocation.Items.AddRange(new object[] {
            "Abra",
            "Agusan Del Norte",
            "Agusan Del Sur",
            "Aklan",
            "Albay",
            "Antique",
            "Apayao",
            "Aurora",
            "Basilan",
            "Bataan",
            "Batanes",
            "Batangas",
            "Benguet",
            "Biliran",
            "Bohol",
            "Bukidnon",
            "Bulacan",
            "Cagayan",
            "Camarines Norte",
            "Camarines Sur",
            "Camiguin",
            "Capiz",
            "Catanduanes",
            "Cavite",
            "Cebu",
            "Compostella Valley",
            "Cotabato",
            "Davao Del Norte",
            "Davao Del Sur",
            "Davao Occidental",
            "Davao Oriental",
            "Dinagat Islands",
            "Eastern Samar",
            "Guimaras",
            "Ifugao",
            "Ilocos Norte",
            "Ilocos Sur",
            "Iloilo",
            "Isabela",
            "Kalinga",
            "La Union",
            "Laguna",
            "Lanao Del Norte",
            "Lanao Del Sur",
            "Leyte",
            "Maguindanao",
            "Marinduque",
            "Masbate",
            "Misamis Occidental",
            "Misamis Oriental",
            "Mountain Province",
            "Negros Occidental",
            "Negros Oriental",
            "Northern Samar",
            "Nueva Ecija",
            "Nueva Vizcaya",
            "Occidental Mindoro",
            "Oriental Mindoro",
            "Palawan",
            "Pampanga",
            "Pangasinan",
            "Quezon",
            "Quirino",
            "Rizal",
            "Romblon",
            "Samar",
            "Sarangani",
            "Siquijor",
            "Sorsogon",
            "South Cotabato",
            "Southern Leyte",
            "Sultan Kudarat",
            "Sulu",
            "Surigao Del Norte",
            "Surigao Del Sur",
            "Tarlac",
            "Tawi-Tawi",
            "Zambales",
            "Zamboanga Del Norte",
            "Zamboanga Del Sur",
            "Zamboanga Sibugay"});
            this.comboBox_addRoomLocation.Location = new System.Drawing.Point(281, 109);
            this.comboBox_addRoomLocation.Name = "comboBox_addRoomLocation";
            this.comboBox_addRoomLocation.Size = new System.Drawing.Size(229, 25);
            this.comboBox_addRoomLocation.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(209, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 18);
            this.label9.TabIndex = 46;
            this.label9.Text = "Location:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 18);
            this.label10.TabIndex = 49;
            this.label10.Text = "Address:";
            // 
            // textBox_addRoomAddress
            // 
            this.textBox_addRoomAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_addRoomAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_addRoomAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_addRoomAddress.Location = new System.Drawing.Point(188, 140);
            this.textBox_addRoomAddress.Name = "textBox_addRoomAddress";
            this.textBox_addRoomAddress.Size = new System.Drawing.Size(465, 24);
            this.textBox_addRoomAddress.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 50;
            this.label6.Text = "Status:";
            // 
            // panel_Status
            // 
            this.panel_Status.Controls.Add(this.comboBox_addRoomAvailability);
            this.panel_Status.Controls.Add(this.label6);
            this.panel_Status.Location = new System.Drawing.Point(400, 44);
            this.panel_Status.Name = "panel_Status";
            this.panel_Status.Size = new System.Drawing.Size(227, 32);
            this.panel_Status.TabIndex = 51;
            this.panel_Status.Visible = false;
            // 
            // comboBox_addRoomAvailability
            // 
            this.comboBox_addRoomAvailability.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_addRoomAvailability.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox_addRoomAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_addRoomAvailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_addRoomAvailability.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_addRoomAvailability.FormattingEnabled = true;
            this.comboBox_addRoomAvailability.Items.AddRange(new object[] {
            "Availability",
            "Not Available",
            "Occupied"});
            this.comboBox_addRoomAvailability.Location = new System.Drawing.Point(59, 0);
            this.comboBox_addRoomAvailability.Name = "comboBox_addRoomAvailability";
            this.comboBox_addRoomAvailability.Size = new System.Drawing.Size(168, 25);
            this.comboBox_addRoomAvailability.TabIndex = 52;
            // 
            // UserControl_AddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.Controls.Add(this.panel_Status);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_addRoomAddress);
            this.Controls.Add(this.comboBox_addRoomLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_ownerMenuAddRoom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_addRoomAmenities);
            this.Controls.Add(this.textBox_addRoomID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_addRoomGuestCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_addRoomPrice);
            this.Controls.Add(this.textBox_pesoSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_addNumRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_regRoomContainer);
            this.Name = "UserControl_AddRoom";
            this.Size = new System.Drawing.Size(670, 465);
            this.Load += new System.EventHandler(this.UserControl_AddRoom_Load);
            this.panel_regRoomContainer.ResumeLayout(false);
            this.panel_regRoomContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addThirdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addSecondImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_addFirstImage)).EndInit();
            this.panel_Status.ResumeLayout(false);
            this.panel_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_regRoomContainer;
        private System.Windows.Forms.CheckBox checkBox_addRoomShrdRoom;
        private System.Windows.Forms.CheckBox checkBox_addRoomPrvtRoom;
        private System.Windows.Forms.CheckBox checkBox_addRoomEntirePlace;
        private System.Windows.Forms.ComboBox comboBox_addRoomGuestCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_addRoomPrice;
        private System.Windows.Forms.TextBox textBox_pesoSign;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_addNumRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_addRoomID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_addThirdImage;
        private System.Windows.Forms.PictureBox pictureBox_addSecondImage;
        private System.Windows.Forms.PictureBox pictureBox_addFirstImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_addRoomAmenities;
        private System.Windows.Forms.Button button_ownerMenuAddRoom;
        private System.Windows.Forms.ComboBox comboBox_addRoomLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_addRoomAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_Status;
        private System.Windows.Forms.ComboBox comboBox_addRoomAvailability;
    }
}
