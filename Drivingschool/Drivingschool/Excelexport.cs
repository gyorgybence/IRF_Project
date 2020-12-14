using DrivingSchool;
using System;
using System.Collections.Generic;
using System.Drawing;
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
                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;


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

        public void Export( List<Student> selected)
        {
            for (int i = 0; i < headers.Length; i++)
            {
                xlSheet.Cells[1, i+1] = headers[i];    // kiirja a fejléceket
            }
            object[,] values = new object[selected.Count, headers.Length];
            int counter = 0;
            foreach ( var x  in selected)
            {

                values[counter, 0] = x.Name;
                values[counter, 1] = x.BirthPlace;
                values[counter, 2] = x.BirthDate.Date.ToString();
                values[counter, 3] = x.MotherName;
                values[counter, 4] = x.Country;
                values[counter, 5] = x.PostalCode;
                values[counter, 6] = x.City;
                values[counter, 7] = x.Address;                         // kiirja az adatokat
                values[counter, 8] = x.Phone;
                values[counter, 9] = x.Email;
                values[counter, 10] = x.IDNum;
                values[counter, 11] = x.Category.ToString();
                values[counter, 12] = x.Azonosito;
                counter++;
             
            }
            xlSheet.get_Range(
             GetCell(2, 1),
             GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;  


            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LightBlue;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range namerange = xlSheet.get_Range(GetCell(2, 1), GetCell(selected.Count+1, 1));
            namerange.Font.Bold = true;

            Excel.Range datarange = xlSheet.get_Range(GetCell(2, 1), GetCell(selected.Count + 1, headers.Length));
            datarange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;



        }
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }


    }
}
