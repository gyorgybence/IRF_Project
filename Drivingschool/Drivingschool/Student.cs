﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchool
{

    public class Student
    {
        public Student()
        {

        }
       

        public enum Categories
        {
            B,      // Személyautó
            AM,     // Robogó
            A1,     // Korlátozott mkp.
            A2,     // Korlátozott mkp.
            A,      // Korlátlan mkp.
            X       // NEM DEFINIÁLT
        }
        // Attribútumok, melyekhez tartozó propertykben valamilyen validáció történik, azaz get; és set; águk nem alapértelmezett.
        private string postalCode;
        private string idNum;
        private string email;

        public Student(string[] adatok) {
            Name = adatok[0];
            BirthPlace = adatok[1];
            BirthDate = DateTime.Parse(adatok[2]);
            MotherName = adatok[3];
            Country = adatok[4];
            PostalCode = adatok[5];
            City = adatok[6];
            Address = adatok[7];
            Phone = adatok[8];
            Email = adatok[9];
            IDNum = adatok[10];
            Category = stringToEnum(adatok[11]);
        }

        // Setterek és Getterek --> Automatikusan létrehoznak attribútumokat, ezeket nem kell külön kiírni!
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string MotherName { get; set; }

        public string Country { get; set; }
        // Valid magyar négyjegyű irányítószám! A jogsi feltétele a magyar lakcím!
        public string PostalCode
        {
            get { return postalCode; }

            set
            {
                if (int.TryParse(value, out _) && value.Length == 4)
                {
                    postalCode = value;
                }
                else { }
            }
        }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        // Valid email formátum!
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        // Csak magyar személyi szám formátum! A jogsi feltétele a magyar személyi megléte!
        public string IDNum
        {
            get { return idNum; }
            set { idNum = value;  }
        }

        public Categories Category { get; set; }

        // Metódusok

        public Categories stringToEnum(string s) {
            switch (s) {
                case "B": return Categories.B;
                case "AM": return Categories.AM;
                case "A1": return Categories.A1;
                case "A2": return Categories.A2;
                case "A": return Categories.A;
                default: return Categories.X;

            }
        }

        // Tömb formában adja vissza az adatokat a ListView számára
        public string[] getArray() {
            string[] ret = { Name, BirthDate.Date.ToString(), BirthPlace, MotherName, Country, PostalCode, City, Address, Phone, Email, IDNum, Category.ToString() };
            return ret;
        }
       
    }
}
