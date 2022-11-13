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
        public Form1()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer1_Tick);
        }
        private void SizeForm()
        {
            var actualSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            actualSize.Width /= 4;
            actualSize.Height /= 4;
            MinimumSize = new Size(actualSize.Width, actualSize.Height);
            MaximumSize = new Size(actualSize.Width, actualSize.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var actualSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            labelResolution.Text = $"Активная область: \n" +
                $"Ширина = {actualSize.Width}, высота = {actualSize.Height}";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            SizeForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (labelResolution.Left > -labelResolution.Width)
            {
                labelResolution.Left -= 5;
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
            string s = contentsOfFile().Replace('\n', ' ');
            labelResolution.Text = s;
        }
    }
}
