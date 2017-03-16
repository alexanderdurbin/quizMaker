using System;
using System.Xml.Linq;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form2 : Form
    {
        private XDocument doc = new XDocument(XDocument.Load("C:\\Users\\Alex\\documents\\visual studio 2015\\Projects\\Math Quiz\\Math Quiz\\Resources\\question_file.xml"));
        private string pictureLocation;
        private Form1 main;

        public Form2(Form1 mainForm)
        {
            InitializeComponent();
            main = mainForm;
            this.CenterToParent();
        }

        private void questionSubmitBtn_Click(object sender, EventArgs e)
        {
            XElement root = doc.Root;

            if (pictureLocation == "" || typeInput.Text == "" || answerInput.Text == "")
            {
                MessageBox.Show("Must have image, tags, and answer to continue!", "Missing Information");
            }
            else
            {
                //add element in this format to xml file:
                // <question type = "typeInput">
                //      <answer> answerInput </answer>
                // </question>

                root.Add(new XElement("Question",
                    new XAttribute("Type", typeInput.Text),
                    new XElement("File", pictureLocation),
                    new XElement("Answer", answerInput.Text)));

                //save document changes
                doc.Save("C:\\Users\\Alex\\documents\\visual studio 2015\\Projects\\Math Quiz\\Math Quiz\\Resources\\question_file.xml");

                //clear inputs
                pictureLocation = "";
                answerInput.Text = "";
                typeInput.Text = "";
            }
        }

        private void imageLoadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dg = new OpenFileDialog())
            {
                dg.Filter = "png files (*.png)|*.png";
                dg.Title = "Load Image";

                if (dg.ShowDialog() == DialogResult.OK)
                {
                    pictureLocation = dg.FileName;   
                    pictureBox1.Image = new Bitmap(dg.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.Refresh();
            this.Close();
        }
    }
}
