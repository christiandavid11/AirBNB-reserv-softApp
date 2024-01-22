using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AirBNB.Model;
using AirBNB.View;
using System.Data.SqlClient;

namespace AirBNB.Model
{
    class Class_Registration
    {
        private int ID;
        private string Purpose;
        private string FirstName;
        private string LastName;
        private string Address;
        private string Month;
        private int Date;
        private int Year;
        private int Age;
        private string ContactNumber;
        private string Email;
        private string Password;
        public Random code = new Random();

        private int RoomID;
        private int OwnerID;
        private string RoomType;
        private int RoomPrice;
        private int GuestCap;
        private int NumberOfBedrooms;
        private string Amenities;
        private string Availability;
        private string Rentee;
        private string DateRented;
        private string DateRentEnd;
        private string Location;
        private string RoomAddress;

        //public string temp_RoomID;
        //public string temp_OwnerID;
        //public string temp_RoomType;
        //public int temp_Price;
        //public int temp_GuestCapacity;
        //public int temp_NumberOfBedrooms;
        //public string temp_Amenities;
        //public string temp_Availability;
        //public string temp_Rentee;
        //public string temp_DateRented;
        //public string temp_DateRentEnded;

        //public byte[] temp_FirstImage;
        //public byte[] temp_SecondImage;
        //public byte[] temp_ThirdImage;

        public string connectionString = "Data Source=DESKTOP-M73T79O\\SQLEXPRESS;Initial Catalog=AirBNB;Integrated Security=True";

        public int temp_ID
        {
            set { ID = value; }
            get { return ID; }
        }

        public string temp_Purpose
        {
            set { Purpose = value; }
            get { return Purpose; }
        }

        public string temp_FirstName
        {
            set { FirstName = value; }
            get { return FirstName; }
        }

        public string temp_LastName
        {
            set { LastName = value; }
            get { return LastName; }
        }

        public string temp_Address
        {
            set { Address = value; }
            get { return Address; }
        }

        public string temp_Month
        {
            set { Month = value; }
            get { return Month; }
        }

        public int temp_Date
        {
            set { Date = value; }
            get { return Date; }
        }

        public int temp_Year
        {
            set { Year = value; }
            get { return Year; }
        }

        public int temp_Age
        {
            set { Age = value; }
            get { return Age; }
        }

        public string temp_ContactNumber
        {
            set { ContactNumber = value; }
            get { return ContactNumber; }
        }

        public string temp_Email
        {
            set { Email = value; }
            get { return Email; }
        }

        public string temp_Password
        {
            set { Password = value; }
            get { return Password; }
        }

        public int temp_RoomID
        {
            set { RoomID = value; }
            get { return RoomID; }
        }

        public int temp_OwnerID
        {
            set { OwnerID = value; }
            get { return OwnerID; }
        }

        public string temp_RoomType
        {
            set { RoomType = value; }
            get { return RoomType; }
        }

        public int temp_RoomPrice
        {
            set { RoomPrice = value; }
            get { return RoomPrice; }
        }

        public int temp_GuestCapacity
        {
            set { GuestCap = value; }
            get { return GuestCap; }
        }

        public int temp_NumberOfBedrooms
        {
            set { NumberOfBedrooms = value; }
            get { return NumberOfBedrooms; }
        }

        public string temp_Ameniites
        {
            set { Amenities = value; }
            get { return Amenities; }
        }

        public string temp_Availability
        {
            set { Availability = value; }
            get { return Availability; }
        }

        public string temp_Rentee
        {
            set { Rentee = value; }
            get { return Rentee; }
        }

        public string temp_DateRented
        {
            set { DateRented = value; }
            get { return DateRented; }
        }

        public string temp_DateRentEnd
        {
            set { DateRentEnd = value; }
            get { return DateRentEnd; }
        }

        public string temp_RoomLocation
        {
            set { Location = value; }
            get { return Location; }
        }

        public string temp_RoomAddress
        {
            set { RoomAddress = value; }
            get { return RoomAddress; }
        }
    }
}