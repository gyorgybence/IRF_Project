using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrivingSchool
{
    enum Categories
    {
        B,      // Személyautó
        BE,     // Személyautó kombinált nehézpótkocsi
        AM,     // Robogó
        A1B,    // Korlátozott mkp. meglévő B-vel
        A1,     // Korlátozott mkp.
        A2,     // Korlátozott mkp.
        A,      // Korlátlan mkp.
        C,      // Teherautó
        CE,     // Teherautó kombinált nehézpótkocsi
        D,      // Autóbusz
        DE      // Autóbusz kombinált nehézpótkocsi
    }
    class Student
    {
        // Attribútumok, melyekhez tartozó propertykben valamilyen validáció történik, azaz get; és set; águk nem alapértelmezett.
        private string postalCode;
        private string idNum;
        private string email;


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
            set { }
        }
        // Csak magyar személyi szám formátum! A jogsi feltétele a magyar személyi megléte!
        public string IDNum
        {
            get { return idNum; }
            set { }
        }

        public Categories Category { get; set; }

        // Metódusok

    }
}
