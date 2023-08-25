using static System.Windows.Forms.LinkLabel;
using System.Text;
using System.IO;
using System.Windows.Forms;
using JavaCompiler.Phases.Lexical;
using JavaCompiler.Models;

namespace JavaCompiler {
    public partial class Home : Form {

        //Atributes
        List<char> listOfItems;

        public Home() {
            InitializeComponent();
        }

        private void createFile_Click(object sender, EventArgs e) {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            ModalTextBox modalTextBox = new ModalTextBox();

            dialog.ShowDialog();
            string path = dialog.SelectedPath;

            modalTextBox.path = path;
            modalTextBox.ShowDialog();

        }

        private void openFile_Click(object sender, EventArgs e) {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = ofd.FileName; //Get path.

            //Set code in rich text box
            richTextBox1.Text = Files.FileUtilities.readAllFile(path);

            //Separate the code in an Array of chars.
            listOfItems = Files.FileUtilities.readFileByChar(path);


        }



        private void Form1_Load(object sender, EventArgs e) {
            menuStrip1.BackColor = Color.Black;


        }

        private void saveFile_Click(object sender, EventArgs e) {

        }

        private void butStart_Click(object sender, EventArgs e) {
            Lexical lexical = new Lexical();

            lexical.mainLoop(listOfItems);
        }

        private void butCompile_Click(object sender, EventArgs e) {
            listOfItems = Files.FileUtilities.readBoxByChar(richTextBox1);
        }
    }
}