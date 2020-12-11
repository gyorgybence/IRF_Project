using DrivingSchool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Drivingschool
{
   
   
    public class Excelexport
    {
        string[] headers = new string[] 
        {
                "Név",
                "Születési hely",
                "Születési idő",
                "Anyja neve",
                "Ország",
                "Irányító szám",
                "Település",
                "Cím",
                "Telefon",
                "Email",
                "Személyi igazolvány szám",
                "Kategória",
                "Azonosító"
        };
        private Excel.Application xlApp; // A Microsoft Excel alkalmazás
        private Excel.Workbook xlWB; // A létrehozott munkafüzet
        private Excel.Worksheet xlSheet; // Munkalap a munkafüzeten belül

        public Excelexport()
        {
            try
            {
                // Excel elindítása és az applikáció objektum betöltése
                xlApp = new Excel.Application();

                // Új munkafüzet
                xlWB = xlApp.Workbooks.Add(Missing.Value);

                // Új munkalap
                xlSheet = xlWB.ActiveSheet;

                
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }

        public void Export(string path, List<Student> s)
        {
            
        }


    }
}
