﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchool
{

    public class Student 
    {
        public Student()
        {

        }
       

        public enum Categories // enumok
        {
            B,      // Személyautó
            AM,     // Robogó
            A1,     // Korlátozott mkp.
            A2,     // Korlátozott mkp.
            A,      // Korlátlan mkp.
            X       // NEM DEFINIÁLT
        }
       
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
            Azonosito = adatok[12];
        }

        
        public string Azonosito { get; private set; } 
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public DateTime BirthDate { get; set; }
        public string MotherName { get; set; }

        public string Country { get; set; }
        
        public string PostalCode
        {
            get { return postalCode; }

            set
            {
                Regex r = new Regex(@"\d{4}");
                if (r.IsMatch(value))
                {
                    postalCode = value;
                }
                else {
                    MessageBox.Show(Name + "tanuló irányítószáma hibás:" + value);
                    postalCode = "0000";
                }
            }
        }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        
        public string Email
        {
            get { return email; }
            set
            {
                Regex r = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                if (r.IsMatch(value))
                {
                    email = value;
                }
                else
                {
                    MessageBox.Show(Name + "e-mail címe hibás: " + value);
                    email = "x";
                }
            }
        }
        
        public string IDNum
        {
            get { return idNum; }
            set 
            { 
                Regex r = new Regex(@"\d{6}[a-zA-Z]{2}");
                if (r.IsMatch(value))
                {
                    idNum = value;
                }
                else
                {
                    MessageBox.Show(Name + " tanuló szig. száma hibás: " + value);
                    idNum = "x";
                }

            }
        }

        public Categories Category { get; set; }

        

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

       
        public string[] getArray() {
            string[] ret = { Name, BirthDate.Date.ToString(), BirthPlace, MotherName, Country, PostalCode, City, Address, Phone, Email, IDNum, Category.ToString(),Azonosito };
            return ret; 
        }
       
    }
}
