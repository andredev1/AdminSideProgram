using ExcelLibrary.SpreadSheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dVchocDataSet1.tbl_ClockIn' table. You can move, or remove it, as needed.
            this.tbl_ClockInTableAdapter1.Fill(this.dVchocDataSet1.tbl_ClockIn);
            // TODO: This line of code loads data into the 'dVchocDataSet.tbl_ClockIn' table. You can move, or remove it, as needed.
            this.tbl_ClockInTableAdapter.Fill(this.dVchocDataSet.tbl_ClockIn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = ("Big_ClockIn_Report " + System.DateTime.Now.ToString("yyyy-MM-dd HHTmm") + ".xls");
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell("fld_firstName");
            worksheet.Cells[0, 1] = new Cell("fld_lastName");
            worksheet.Cells[0, 2] = new Cell("fld_personalIDnumber");
            worksheet.Cells[0, 3] = new Cell("fld_osName");
            worksheet.Cells[0, 4] = new Cell("fld_osVersion");
            worksheet.Cells[0, 5] = new Cell("fld_browserName");
            worksheet.Cells[0, 6] = new Cell("fld_browserVersion");
            worksheet.Cells[0, 7] = new Cell("fld_latitube");
            worksheet.Cells[0, 8] = new Cell("fld_longitude");
            worksheet.Cells[0, 9] = new Cell("fld_dateTime");
            
            List<string[]> queryResult = new back.SQLConnect().GetClassList();
            for (int i = 0; i < queryResult.Count ; i++)
            {
                worksheet.Cells[i+1, 0] = new Cell(queryResult[i].ToArray()[0]);
                worksheet.Cells[i+1, 1] = new Cell(queryResult[i].ToArray()[1]);
                worksheet.Cells[i+1, 2] = new Cell(queryResult[i].ToArray()[2]);
                worksheet.Cells[i+1, 3] = new Cell(queryResult[i].ToArray()[3]);
                worksheet.Cells[i+1, 4] = new Cell(queryResult[i].ToArray()[4]);
                worksheet.Cells[i+1, 5] = new Cell(queryResult[i].ToArray()[5]);
                worksheet.Cells[i+1, 6] = new Cell(queryResult[i].ToArray()[6]);
                worksheet.Cells[i+1, 7] = new Cell(queryResult[i].ToArray()[7]);
                worksheet.Cells[i+1, 8] = new Cell(queryResult[i].ToArray()[8]);
                worksheet.Cells[i+1, 9] = new Cell(queryResult[i].ToArray()[9]);
            }


            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0];

            //foreach (Pair, Cell> cell in sheet.Cells) 
            //{
            //    dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value;
            //}

            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }

            MessageBox.Show("File Created");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string file = ("DV pod clock in list " + System.DateTime.Now.ToString("yyyy-MM-dd HHTmm") + ".xls");
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell("fld_firstName");
            worksheet.Cells[0, 1] = new Cell("fld_lastName");
            worksheet.Cells[0, 2] = new Cell("fld_personalIDnumber");
            worksheet.Cells[0, 3] = new Cell("fld_osName");
            worksheet.Cells[0, 4] = new Cell("fld_osVersion");
            worksheet.Cells[0, 5] = new Cell("fld_browserName");
            worksheet.Cells[0, 6] = new Cell("fld_browserVersion");
            worksheet.Cells[0, 7] = new Cell("fld_latitube");
            worksheet.Cells[0, 8] = new Cell("fld_longitude");
            worksheet.Cells[0, 9] = new Cell("fld_dateTime");

            List<string[]> queryResult = new back.SQLConnect().GetMufamadiList();
                int i= PrintToCells(queryResult, worksheet, 1);


            queryResult = new back.SQLConnect().GetSekgotaList();
            i = PrintToCells(queryResult, worksheet, i)+1;

            queryResult = new back.SQLConnect().GetHobyaneList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMzimkhuluList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMasogoList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetNyamaList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetZuluList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMonyebodiList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetKhatiList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetDubeList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetNgobeniList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetKomaneList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMatsitseList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMogotsiList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetRangaList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMukwenaList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetNtlavanaList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetBengeList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetHufkeList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetRossList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetSolomonsList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMasekoList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetMbekwaList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetCebeniList();
            i = PrintToCells(queryResult, worksheet, i) + 1;

            queryResult = new back.SQLConnect().GetSidiList();
            i = PrintToCells(queryResult, worksheet, i) + 1;



            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0];

            //foreach (Pair, Cell> cell in sheet.Cells) 
            //{
            //    dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value;
            //}

            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }

            MessageBox.Show("File Created");

        }
        public int PrintToCells(List<string[]> queryResult, Worksheet worksheet, int rowNumber)
        {
            int i = rowNumber;
            for (int j = 0 ; j < queryResult.Count; i++, j++)
            {
                worksheet.Cells[i + 1, 0] = new Cell(queryResult[j].ToArray()[0]);
                worksheet.Cells[i + 1, 1] = new Cell(queryResult[j].ToArray()[1]);
                worksheet.Cells[i + 1, 2] = new Cell(queryResult[j].ToArray()[2]);
                worksheet.Cells[i + 1, 3] = new Cell(queryResult[j].ToArray()[3]);
                worksheet.Cells[i + 1, 4] = new Cell(queryResult[j].ToArray()[4]);
                worksheet.Cells[i + 1, 5] = new Cell(queryResult[j].ToArray()[5]);
                worksheet.Cells[i + 1, 6] = new Cell(queryResult[j].ToArray()[6]);
                worksheet.Cells[i + 1, 7] = new Cell(queryResult[j].ToArray()[7]);
                worksheet.Cells[i + 1, 8] = new Cell(queryResult[j].ToArray()[8]);
                worksheet.Cells[i + 1, 9] = new Cell(queryResult[j].ToArray()[9]);
            }
            return i;
        }
    }
}
