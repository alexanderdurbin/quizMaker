using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace Math_Quiz
{
    public partial class Form1 : Form
    {
        //question database
        XDocument doc;
        
        //holds questions for quiz, indexes of selected answers, current question displayed
        List<Question> questions = new List<Question>();
        List<int> selectedAnswers = new List<int>();
        int currentQuestion = 0;

        public Form1()
        {
            InitializeComponent();
            doc = new XDocument(XDocument.Load("C:\\Users\\Alex\\documents\\visual studio 2015\\Projects\\Math Quiz\\Math Quiz\\Resources\\question_file.xml"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            loadTags();
        }


        private void addNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //allow user to add new questions
            Form2 frm = new Form2(this);
            frm.Show();
        }

        private void startNewQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reload page elements
            this.Refresh();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //empty prior quiz, 
            questions.Clear();
            selectedAnswers.Clear();
            currentQuestion = 0;


            //load up new quiz, 
            int m;
            Int32.TryParse(questionCountTxtBox.Text, out m);
            loadQuiz(tagsTxtBox.Text, m);

            //enable buttons
            if (questions.Count() > 0)
            {
                nextBtn.Enabled = true;
                previousBtn.Enabled = true;
                submitAnswersBtn.Enabled = true;
            }

            //display first question
            pictureBox1.ImageLocation = questions.First().fileLocation;
        }

        private void loadQuiz(string tag, int n)
        {
            //(string type of question, int number of questions to load)

            //iterate through xml file and load a List<> / Dictionary that contains image locations and question answers for 
            //question elements that contain the given tag, index serves as question number.
            //randomize the list / dictionary. 
            IEnumerable<XElement> quiz =
                from el in doc.Descendants("Question")
                where el.Attribute("Type").Value.Contains(tag)
                select el;

            if (quiz != null)
            {
                foreach(XElement e in quiz)
                {
                    //select random index to insert question...
                    questions.Add(new Question(e.Element("File").Value, e.Element("Answer").Value));
                }
            }
            else
            {
                MessageBox.Show("Invalid or missing question type", "Missing Question Type");
            }
        }

        
        private void loadTags()
        {
            //loads question types into list box for user to select from
            IEnumerable<string> tags =
                from at in doc.Descendants("Question")
                select (string)at.Attribute("Type");

            foreach (string at in tags) {
                if (at != null)
                {
                    string[] s = at.Split(',');
                    
                    foreach (string i in s)
                    {
                        string a = i.Trim();
                        if (!tagListBox.Items.Contains(a))
                            tagListBox.Items.Add(a);
                    }
                }
            }
        }



        private void tagListBox_DoubleClick(object sender, EventArgs e)
        {
            //add double clicked tag to question type
            tagsTxtBox.Text += tagListBox.SelectedItem;
        }

        private void tagsTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows user to use enter key to start quiz
            if (e.KeyChar == (char)Keys.Return)
            {
                submitBtn_Click(sender, e);
            }
        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            //advances to new question, adds current response to selectedAnswers list
            //selectedAnswers.Add(radio);
            currentQuestion++;

            if (currentQuestion >= questions.Count())
            {
                currentQuestion--;
                //click submitAnswers button?
            }
            else
            {
                pictureBox1.ImageLocation = questions[currentQuestion].fileLocation;
            }
        }


        private void previousBtn_Click(object sender, EventArgs e)
        {
            //go back to prior question, load previously selected answer
            if(currentQuestion > 0)
                currentQuestion--;

            //load answer that was selected
            

            pictureBox1.ImageLocation = questions[currentQuestion].fileLocation;
        }

    }
}
