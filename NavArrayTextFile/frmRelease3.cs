using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavArrayTextFile
{
    public partial class frmRelease3 : Form
    {
        public frmRelease3()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            Visible = false;
        }

        private void frmRelease3_Load(object sender, EventArgs e)
        {
            string[] lines = System.IO.File.ReadAllLines
    (@"C:\Users\500153389\source\repos\ArrayTextFile\release-3.txt");


            bool check = false;

            //line number - start
            int x = 0;
            string spaceLine = "\n";
            foreach (string line in lines)
            {
                Console.WriteLine(line);
                if (check)
                {

                    x++;
                }
                if (line != null)
                {
                    if (line.Contains("FROM TO"))
                    {
                        check = true;



                        lstDisplay.Items.Add(lines[x = 1]);
                        lstDisplay.Items.Add(lines[x = 2]);
                        lstDisplay.Items.Add(lines[x = 3]);
                        lstDisplay.Items.Add(lines[x = 4]);


                        //---------------------------------
                        lstDisplay.Items.Add(spaceLine);
                        lstDisplay.Items.Add(lines[x = 10]);
                        lstDisplay.Items.Add(line);
                        lstDisplay.Items.Add(lines[x = 1]);
                        lstDisplay.Items.Add(lines[x = 13]);
                        lstDisplay.Items.Add(spaceLine);
                        lstDisplay.Items.Add(spaceLine);
                        lstDisplay.Items.Add(spaceLine);
                        lstDisplay.Items.Add(spaceLine);


                        //reset count
                        x = 0;
                    }
                    if (x > 3)
                    {
                        check = false;
                    }
                }
            }
        }
    }
}
