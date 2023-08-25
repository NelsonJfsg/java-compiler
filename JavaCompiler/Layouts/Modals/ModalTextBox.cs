using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaCompiler
{
    public partial class ModalTextBox : Form
    {

        //Atributes
        public string path = null;
        private string fileName = null;

        public ModalTextBox()
        {
            this.path = path;
            InitializeComponent();

        }



        private void butCreateFile_Click(object sender, EventArgs e)
        {
            fileName = tbFileName.Text;

            try
            {

                if (fileName.Equals(""))
                {
                    MessageBox.Show("Empty file name.");
                }
                else
                {

                    File.Create(@path + @"\\" + tbFileName.Text + ".jfsg"); //This is for u.
                    MessageBox.Show("File created.");
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Something went wrong." + "\n" + ex);

            }
        }

        private void ModalTextBox_Load(object sender, EventArgs e)
        {
        }
    }
}
