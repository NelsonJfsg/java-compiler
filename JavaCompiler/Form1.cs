using static System.Windows.Forms.LinkLabel;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace JavaCompiler
{
    public partial class Form1 : Form
    {

        //Atributes
        List<char> listOfItems;

        public Form1()
        {
            InitializeComponent();
        }

        private void createFile_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            ModalTextBox modalTextBox = new ModalTextBox();

            dialog.ShowDialog();
            string path = dialog.SelectedPath;

            modalTextBox.path = path;
            modalTextBox.ShowDialog();

        }

        private void openFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = ofd.FileName; //Get path.

            readAllFile(path);
            listOfItems = readFileByChar(path);


        }

        private List<char> readFileByChar(string @path)
        {

            //Read char
            var list = new List<char>();
            StreamReader inputFile = new StreamReader(path);
            //StreamWriter outputFile = new StreamWriter(path);

            for (int i = 0; !inputFile.EndOfStream; i++)
            {
                char line = (char)inputFile.Read();
                list.Add(line);
            }

            return list;
        }

        private void readAllFile(string path)
        {

            //Read all file.
            string code = File.ReadAllText(path);
            richTextBox1.Text = code;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Black;
        }
    }
}