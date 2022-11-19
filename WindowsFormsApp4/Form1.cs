using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Enabled = false;
            timer.Tick += new EventHandler(timer1_Tick);
        }
        private void SizeForm()
        {
            var actualSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            actualSize.Width /= 3;
            actualSize.Height /= 3;
            MinimumSize = new Size(actualSize.Width, actualSize.Height);
            MaximumSize = new Size(actualSize.Width, actualSize.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SizeForm();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (labelResolution.Left > -labelResolution.Width)
            {
                labelResolution.Left -= 1;
            }
            else
            {
                labelResolution.Left = this.Width;
            }
        }

        private string contentsOfFile() 
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "c_sharp files (*.cs)|*.cs|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();
                StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
                reader.Close();
            }
            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            return fileContent;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            labelResolution.Text = contentsOfFile().Replace("\r\n", " ");
        }

        private void buttonClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void buttonOpenFile_MouseClick(object sender, MouseEventArgs e)
        {   
            labelResolution.Text = contentsOfFile().Replace("\r\n", " ");
            timer.Enabled = true;
        }

        private void buttonChange_MouseClick(object sender, MouseEventArgs e)
        {
            var height = this.Height;
            var width = this.Width; 
            System.Drawing.Drawing2D.GraphicsPath Form_Path = 
                new System.Drawing.Drawing2D.GraphicsPath();
            Form_Path.AddPolygon(new Point[]
            {
                new Point(0, 0),
                new Point(width, 0),
                new Point(width / 2, height / 2),
                new Point(width, height),
                new Point(0, height),
                new Point(width / 2, height / 2),
            });
            
            Region Form_Region = new Region(Form_Path);
            this.Region = Form_Region;
        }
    }
}
