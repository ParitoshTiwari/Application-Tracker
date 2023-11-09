using Aplication_Tracker.Models;
using OfficeOpenXml;
using System;
using System.IO;
using System.Windows.Forms;

namespace Aplication_Tracker
{
    public partial class ApplicationTracker : Form
    {
        public const string path = "C:\\Users\\Parit\\source\\repos\\Aplication Tracker\\Aplication Tracker\\Tracker.xlsx";
        
        public TrackerData TrackerObj { get; set; }
        public ApplicationTracker()
        {
            InitializeComponent();
            TrackerObj = new TrackerData();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            TrackerObj = new TrackerData();
            companyName.Text = string.Empty;
            IsH1B.Checked = false;
            IsLinkedIn.Checked = false;
            IsIndeed.Checked = false;
            isHandShake.Checked = false;
            isSde.Checked = false;
            contactName.Text = string.Empty;
            notes.Text = string.Empty;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(path);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int newRow = worksheet.Dimension.Rows + 1;

                    
                    TrackerObj.CompanyName = companyName.Text;
                    TrackerObj.ContactName = contactName.Text;
                    TrackerObj.Notes = notes.Text;
                    worksheet.Cells[newRow, 1].Value = TrackerObj.CompanyName;
                    worksheet.Cells[newRow, 2].Value = TrackerObj.IsLinkedIn;
                    worksheet.Cells[newRow, 3].Value = TrackerObj.IsIndeed;
                    worksheet.Cells[newRow, 4].Value = TrackerObj.IsHandshake;
                    worksheet.Cells[newRow, 5].Value = TrackerObj.IsSDE;
                    worksheet.Cells[newRow, 6].Value = TrackerObj.ContactName;
                    worksheet.Cells[newRow, 7].Value = TrackerObj.Notes;
                    worksheet.Cells[newRow, 8].Value = TrackerObj.IsH1B;
                    worksheet.Cells[newRow, 9].Value = TrackerObj.DateAndDay;
                    package.SaveAsync();
                }


                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                TrackerObj = new TrackerData();
                companyName.Text = string.Empty;
                IsH1B.Checked = false;
                IsLinkedIn.Checked = false;
                IsIndeed.Checked = false;
                isHandShake.Checked = false;
                isSde.Checked = false;
                contactName.Text = string.Empty;
                notes.Text = string.Empty;
            }
        }

        private void IsH1B_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TrackerObj.IsH1B = chk.Checked;
        }

        private void IsLinkedIn_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TrackerObj.IsLinkedIn = chk.Checked;
        }

        private void IsIndeed_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TrackerObj.IsIndeed = chk.Checked;
        }

        private void isHandShake_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TrackerObj.IsHandshake = chk.Checked;
        }

        private void isSde_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            TrackerObj.IsSDE = chk.Checked;
        }

        private void contactName_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text) || e.Data.GetDataPresent(DataFormats.Html))
            {
                e.Effect = DragDropEffects.Link;
                TrackerObj.ContactName = e.Data.ToString();
            }
        }
    }
}
