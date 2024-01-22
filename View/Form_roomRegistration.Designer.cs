namespace AirBNB.View
{
    partial class Form_roomRegistration
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
            this.button_roomRegClose = new System.Windows.Forms.Button();
            this.panel_roomRegBorder = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_regNumRooms = new System.Windows.Forms.ComboBox();
            this.richTextBox_regRoomAmenities = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_regRoomContainer = new System.Windows.Forms.Panel();
            this.checkBox_regRoomShrdRoom = new System.Windows.Forms.CheckBox();
            this.checkBox_regRoomPrvtRoom = new System.Windows.Forms.CheckBox();
            this.checkBox_regRoomEntirePlace = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_pesoSign = new System.Windows.Forms.TextBox();
            this.textBox_regRoomPrice = new System.Windows.Forms.TextBox();
            this.pictureBox_FirstRegImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox_ThirdRegImage = new System.Windows.Forms.PictureBox();
            this.pictureBox_SecondRegImage = new System.Windows.Forms.PictureBox();
            this.comboBox_regRoomGuestCap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_RegRoomSubmit = new System.Windows.Forms.Button();
            this.textBox_RegRoomID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_RoomOwnerID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_regRoomLocation = new System.Windows.Forms.ComboBox();
            this.textBox_regRoomAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_roomRegBorder.SuspendLayout();
            this.panel_regRoomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FirstRegImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ThirdRegImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SecondRegImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button_roomRegClose
            // 
            this.button_roomRegClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_roomRegClose.FlatAppearance.BorderSize = 0;
            this.button_roomRegClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_roomRegClose.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_roomRegClose.Location = new System.Drawing.Point(859, 0);
            this.button_roomRegClose.Name = "button_roomRegClose";
            this.button_roomRegClose.Size = new System.Drawing.Size(61, 33);
            this.button_roomRegClose.TabIndex = 1;
            this.button_roomRegClose.Text = "X";
            this.button_roomRegClose.UseVisualStyleBackColor = true;
            this.button_roomRegClose.Click += new System.EventHandler(this.button_roomRegClose_Click);
            this.button_roomRegClose.MouseLeave += new System.EventHandler(this.button_roomRegClose_MouseLeave);
            this.button_roomRegClose.MouseHover += new System.EventHandler(this.button_roomRegClose_MouseHover);
            // 
            // panel_roomRegBorder
            // 
            this.panel_roomRegBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(170)))), ((int)(((byte)(141)))));
            this.panel_roomRegBorder.Controls.Add(this.label12);
            this.panel_roomRegBorder.Controls.Add(this.button_roomRegClose);
            this.panel_roomRegBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_roomRegBorder.Location = new System.Drawing.Point(0, 0);
            this.panel_roomRegBorder.Name = "panel_roomRegBorder";
            this.panel_roomRegBorder.Size = new System.Drawing.Size(920, 33);
            this.panel_roomRegBorder.TabIndex = 3;
            this.panel_roomRegBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_roomRegBorder_MouseDown);
            this.panel_roomRegBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_roomRegBorder_MouseMove);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(-1, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(320, 25);
            this.label12.TabIndex = 32;
            this.label12.Text = "Airbnb, OVBS - Room Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of Bedrooms:";
            // 
            // comboBox_regNumRooms
            // 
            this.comboBox_regNumRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_regNumRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_regNumRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_regNumRooms.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_regNumRooms.FormattingEnabled = true;
            this.comboBox_regNumRooms.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_regNumRooms.Location = new System.Drawing.Point(352, 139);
            this.comboBox_regNumRooms.Name = "comboBox_regNumRooms";
            this.comboBox_regNumRooms.Size = new System.Drawing.Size(74, 28);
            this.comboBox_regNumRooms.TabIndex = 15;
            // 
            // richTextBox_regRoomAmenities
            // 
            this.richTextBox_regRoomAmenities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.richTextBox_regRoomAmenities.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_regRoomAmenities.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_regRoomAmenities.Location = new System.Drawing.Point(102, 276);
            this.richTextBox_regRoomAmenities.Name = "richTextBox_regRoomAmenities";
            this.richTextBox_regRoomAmenities.Size = new System.Drawing.Size(202, 156);
            this.richTextBox_regRoomAmenities.TabIndex = 18;
            this.richTextBox_regRoomAmenities.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Amenities:";
            // 
            // panel_regRoomContainer
            // 
            this.panel_regRoomContainer.Controls.Add(this.checkBox_regRoomShrdRoom);
            this.panel_regRoomContainer.Controls.Add(this.checkBox_regRoomPrvtRoom);
            this.panel_regRoomContainer.Controls.Add(this.checkBox_regRoomEntirePlace);
            this.panel_regRoomContainer.Location = new System.Drawing.Point(19, 46);
            this.panel_regRoomContainer.Name = "panel_regRoomContainer";
            this.panel_regRoomContainer.Size = new System.Drawing.Size(148, 135);
            this.panel_regRoomContainer.TabIndex = 20;
            // 
            // checkBox_regRoomShrdRoom
            // 
            this.checkBox_regRoomShrdRoom.AutoSize = true;
            this.checkBox_regRoomShrdRoom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_regRoomShrdRoom.Location = new System.Drawing.Point(4, 97);
            this.checkBox_regRoomShrdRoom.Name = "checkBox_regRoomShrdRoom";
            this.checkBox_regRoomShrdRoom.Size = new System.Drawing.Size(129, 24);
            this.checkBox_regRoomShrdRoom.TabIndex = 2;
            this.checkBox_regRoomShrdRoom.Text = "Shared Room";
            this.checkBox_regRoomShrdRoom.UseVisualStyleBackColor = true;
            this.checkBox_regRoomShrdRoom.CheckedChanged += new System.EventHandler(this.checkBox_regRoomShrdRoom_CheckedChanged);
            // 
            // checkBox_regRoomPrvtRoom
            // 
            this.checkBox_regRoomPrvtRoom.AutoSize = true;
            this.checkBox_regRoomPrvtRoom.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_regRoomPrvtRoom.Location = new System.Drawing.Point(4, 51);
            this.checkBox_regRoomPrvtRoom.Name = "checkBox_regRoomPrvtRoom";
            this.checkBox_regRoomPrvtRoom.Size = new System.Drawing.Size(127, 24);
            this.checkBox_regRoomPrvtRoom.TabIndex = 1;
            this.checkBox_regRoomPrvtRoom.Text = "Private Room";
            this.checkBox_regRoomPrvtRoom.UseVisualStyleBackColor = true;
            this.checkBox_regRoomPrvtRoom.CheckedChanged += new System.EventHandler(this.checkBox_regRoomPrvtRoom_CheckedChanged);
            // 
            // checkBox_regRoomEntirePlace
            // 
            this.checkBox_regRoomEntirePlace.AutoSize = true;
            this.checkBox_regRoomEntirePlace.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_regRoomEntirePlace.Location = new System.Drawing.Point(4, 12);
            this.checkBox_regRoomEntirePlace.Name = "checkBox_regRoomEntirePlace";
            this.checkBox_regRoomEntirePlace.Size = new System.Drawing.Size(114, 24);
            this.checkBox_regRoomEntirePlace.TabIndex = 0;
            this.checkBox_regRoomEntirePlace.Text = "Entire Place";
            this.checkBox_regRoomEntirePlace.UseVisualStyleBackColor = true;
            this.checkBox_regRoomEntirePlace.CheckedChanged += new System.EventHandler(this.checkBox_regRoomEntirePlace_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Price:";
            // 
            // textBox_pesoSign
            // 
            this.textBox_pesoSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_pesoSign.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_pesoSign.Enabled = false;
            this.textBox_pesoSign.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pesoSign.Location = new System.Drawing.Point(322, 49);
            this.textBox_pesoSign.Name = "textBox_pesoSign";
            this.textBox_pesoSign.ReadOnly = true;
            this.textBox_pesoSign.Size = new System.Drawing.Size(13, 21);
            this.textBox_pesoSign.TabIndex = 22;
            this.textBox_pesoSign.Text = "₱";
            // 
            // textBox_regRoomPrice
            // 
            this.textBox_regRoomPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_regRoomPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_regRoomPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_regRoomPrice.Location = new System.Drawing.Point(335, 46);
            this.textBox_regRoomPrice.Name = "textBox_regRoomPrice";
            this.textBox_regRoomPrice.Size = new System.Drawing.Size(114, 28);
            this.textBox_regRoomPrice.TabIndex = 23;
            // 
            // pictureBox_FirstRegImage
            // 
            this.pictureBox_FirstRegImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_FirstRegImage.Location = new System.Drawing.Point(10, 8);
            this.pictureBox_FirstRegImage.Name = "pictureBox_FirstRegImage";
            this.pictureBox_FirstRegImage.Size = new System.Drawing.Size(170, 135);
            this.pictureBox_FirstRegImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_FirstRegImage.TabIndex = 24;
            this.pictureBox_FirstRegImage.TabStop = false;
            this.pictureBox_FirstRegImage.DoubleClick += new System.EventHandler(this.pictureBox_FirstRegImage_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox_ThirdRegImage);
            this.panel1.Controls.Add(this.pictureBox_SecondRegImage);
            this.panel1.Controls.Add(this.pictureBox_FirstRegImage);
            this.panel1.Location = new System.Drawing.Point(361, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 160);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox_ThirdRegImage
            // 
            this.pictureBox_ThirdRegImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ThirdRegImage.Location = new System.Drawing.Point(362, 8);
            this.pictureBox_ThirdRegImage.Name = "pictureBox_ThirdRegImage";
            this.pictureBox_ThirdRegImage.Size = new System.Drawing.Size(170, 135);
            this.pictureBox_ThirdRegImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ThirdRegImage.TabIndex = 28;
            this.pictureBox_ThirdRegImage.TabStop = false;
            this.pictureBox_ThirdRegImage.DoubleClick += new System.EventHandler(this.pictureBox_ThirdRegImage_DoubleClick);
            // 
            // pictureBox_SecondRegImage
            // 
            this.pictureBox_SecondRegImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_SecondRegImage.Location = new System.Drawing.Point(186, 8);
            this.pictureBox_SecondRegImage.Name = "pictureBox_SecondRegImage";
            this.pictureBox_SecondRegImage.Size = new System.Drawing.Size(170, 135);
            this.pictureBox_SecondRegImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_SecondRegImage.TabIndex = 28;
            this.pictureBox_SecondRegImage.TabStop = false;
            this.pictureBox_SecondRegImage.DoubleClick += new System.EventHandler(this.pictureBox_SecondRegImage_DoubleClick);
            // 
            // comboBox_regRoomGuestCap
            // 
            this.comboBox_regRoomGuestCap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_regRoomGuestCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_regRoomGuestCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_regRoomGuestCap.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_regRoomGuestCap.FormattingEnabled = true;
            this.comboBox_regRoomGuestCap.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_regRoomGuestCap.Location = new System.Drawing.Point(352, 93);
            this.comboBox_regRoomGuestCap.Name = "comboBox_regRoomGuestCap";
            this.comboBox_regRoomGuestCap.Size = new System.Drawing.Size(74, 28);
            this.comboBox_regRoomGuestCap.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Guest Capacity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Room ID:";
            // 
            // button_RegRoomSubmit
            // 
            this.button_RegRoomSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(177)))));
            this.button_RegRoomSubmit.FlatAppearance.BorderSize = 0;
            this.button_RegRoomSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RegRoomSubmit.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RegRoomSubmit.Location = new System.Drawing.Point(436, 446);
            this.button_RegRoomSubmit.Name = "button_RegRoomSubmit";
            this.button_RegRoomSubmit.Size = new System.Drawing.Size(112, 52);
            this.button_RegRoomSubmit.TabIndex = 29;
            this.button_RegRoomSubmit.Text = "Submit";
            this.button_RegRoomSubmit.UseVisualStyleBackColor = false;
            this.button_RegRoomSubmit.Click += new System.EventHandler(this.button_RegRoomSubmit_Click);
            // 
            // textBox_RegRoomID
            // 
            this.textBox_RegRoomID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_RegRoomID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RegRoomID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RegRoomID.Location = new System.Drawing.Point(760, 46);
            this.textBox_RegRoomID.Name = "textBox_RegRoomID";
            this.textBox_RegRoomID.ReadOnly = true;
            this.textBox_RegRoomID.Size = new System.Drawing.Size(149, 26);
            this.textBox_RegRoomID.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(367, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(373, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Double Click Boxes to Enter Images";
            // 
            // textBox_RoomOwnerID
            // 
            this.textBox_RoomOwnerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_RoomOwnerID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_RoomOwnerID.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RoomOwnerID.Location = new System.Drawing.Point(760, 92);
            this.textBox_RoomOwnerID.Name = "textBox_RoomOwnerID";
            this.textBox_RoomOwnerID.ReadOnly = true;
            this.textBox_RoomOwnerID.Size = new System.Drawing.Size(149, 26);
            this.textBox_RoomOwnerID.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Room Owner ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 36;
            this.label9.Text = "Location:";
            // 
            // comboBox_regRoomLocation
            // 
            this.comboBox_regRoomLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.comboBox_regRoomLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_regRoomLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_regRoomLocation.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_regRoomLocation.FormattingEnabled = true;
            this.comboBox_regRoomLocation.Items.AddRange(new object[] {
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
            this.comboBox_regRoomLocation.Location = new System.Drawing.Point(106, 200);
            this.comboBox_regRoomLocation.Name = "comboBox_regRoomLocation";
            this.comboBox_regRoomLocation.Size = new System.Drawing.Size(229, 28);
            this.comboBox_regRoomLocation.TabIndex = 37;
            // 
            // textBox_regRoomAddress
            // 
            this.textBox_regRoomAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.textBox_regRoomAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_regRoomAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_regRoomAddress.Location = new System.Drawing.Point(436, 200);
            this.textBox_regRoomAddress.Name = "textBox_regRoomAddress";
            this.textBox_regRoomAddress.Size = new System.Drawing.Size(465, 28);
            this.textBox_regRoomAddress.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(357, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Address:";
            // 
            // Form_roomRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(208)))));
            this.ClientSize = new System.Drawing.Size(920, 510);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_regRoomAddress);
            this.Controls.Add(this.comboBox_regRoomLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_RoomOwnerID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_RegRoomID);
            this.Controls.Add(this.button_RegRoomSubmit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_regRoomGuestCap);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_regRoomPrice);
            this.Controls.Add(this.textBox_pesoSign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_regRoomContainer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox_regRoomAmenities);
            this.Controls.Add(this.comboBox_regNumRooms);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_roomRegBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_roomRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_roomRegistration";
            this.Load += new System.EventHandler(this.Form_roomRegistration_Load);
            this.panel_roomRegBorder.ResumeLayout(false);
            this.panel_roomRegBorder.PerformLayout();
            this.panel_regRoomContainer.ResumeLayout(false);
            this.panel_regRoomContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_FirstRegImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ThirdRegImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SecondRegImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_roomRegClose;
        private System.Windows.Forms.Panel panel_roomRegBorder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_regNumRooms;
        private System.Windows.Forms.RichTextBox richTextBox_regRoomAmenities;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_regRoomContainer;
        private System.Windows.Forms.CheckBox checkBox_regRoomShrdRoom;
        private System.Windows.Forms.CheckBox checkBox_regRoomPrvtRoom;
        private System.Windows.Forms.CheckBox checkBox_regRoomEntirePlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pesoSign;
        private System.Windows.Forms.TextBox textBox_regRoomPrice;
        private System.Windows.Forms.PictureBox pictureBox_FirstRegImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox_regRoomGuestCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox_ThirdRegImage;
        private System.Windows.Forms.PictureBox pictureBox_SecondRegImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_RegRoomSubmit;
        private System.Windows.Forms.TextBox textBox_RegRoomID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_RoomOwnerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_regRoomLocation;
        private System.Windows.Forms.TextBox textBox_regRoomAddress;
        private System.Windows.Forms.Label label10;
    }
}