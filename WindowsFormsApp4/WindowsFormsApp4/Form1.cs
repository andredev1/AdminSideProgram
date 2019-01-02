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
            // TODO: This line of code loads data into the 'dVchocDataSet.tbl_ClockIn' table. You can move, or remove it, as needed.
            this.tbl_ClockInTableAdapter.Fill(this.dVchocDataSet.tbl_ClockIn);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = ("ClockIn_Report " + System.DateTime.Now.ToString("yyyy-MM-dd HHTmm") + ".xls");
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell("fld_id");
            worksheet.Cells[0, 1] = new Cell("fld_firstName");
            worksheet.Cells[0, 2] = new Cell("fld_lastName");
            worksheet.Cells[0, 3] = new Cell("fld_personalIDnumber");
            worksheet.Cells[0, 4] = new Cell("fld_osName");
            worksheet.Cells[0, 5] = new Cell("fld_osVersion");
            worksheet.Cells[0, 6] = new Cell("fld_browserName");
            worksheet.Cells[0, 7] = new Cell("fld_browserVersion");
            worksheet.Cells[0, 8] = new Cell("fld_navigatorUserAgent");
            worksheet.Cells[0, 9] = new Cell("fld_navigatorAppVersion");
            worksheet.Cells[0, 10] = new Cell("fld_navigatorPlatform");
            worksheet.Cells[0, 11] = new Cell("fld_navigatorVendor");
            worksheet.Cells[0, 12] = new Cell("fld_latitube");
            worksheet.Cells[0, 13] = new Cell("fld_longitude");
            worksheet.Cells[0, 14] = new Cell("fld_dateTime");
            
            List<string[]> queryResult = new back.SQLConnect().GetClassList();

            worksheet.Cells[1, 0] = new Cell(queryResult[0].ToArray()[0]);
            worksheet.Cells[1, 1] = new Cell(queryResult[0].ToArray()[1]);
            worksheet.Cells[1, 2] = new Cell(queryResult[0].ToArray()[2]);
            worksheet.Cells[1, 3] = new Cell(queryResult[0].ToArray()[3]);
            worksheet.Cells[1, 4] = new Cell(queryResult[0].ToArray()[4]);
            worksheet.Cells[1, 5] = new Cell(queryResult[0].ToArray()[5]);
            worksheet.Cells[1, 6] = new Cell(queryResult[0].ToArray()[6]);
            worksheet.Cells[1, 7] = new Cell(queryResult[0].ToArray()[7]);
            worksheet.Cells[1, 8] = new Cell(queryResult[0].ToArray()[8]);
            worksheet.Cells[1, 9] = new Cell(queryResult[0].ToArray()[9]);
            worksheet.Cells[1, 10] = new Cell(queryResult[0].ToArray()[10]);
            worksheet.Cells[1, 11] = new Cell(queryResult[0].ToArray()[11]);
            worksheet.Cells[1, 12] = new Cell(queryResult[0].ToArray()[12]);
            worksheet.Cells[1, 13] = new Cell(queryResult[0].ToArray()[13]);
            worksheet.Cells[1, 14] = new Cell(queryResult[0].ToArray()[14]);



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
    }
}
