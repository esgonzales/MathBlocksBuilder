using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//E. Gonzales 2018

namespace MathBlockBuilder_v2
{
    public partial class Form1 : Form
    {
        // The following app was written by E. Gonzales 2018 for the sole purpose of creating an app that aids children in learning basic math
        // This app is not endorsed by any company that provides school material for learning and this app cannot be sold as such. 
        //Variables that are used in the form
        bool firstTry = true; // captures whether it's your first time answering the question
        int answer; // captures the answer to the math problem
        int correct = 0; // captures how many times you answered the question on the first try
        int data; // captures how many problems you have done
        int index = 10; // index of blocks
        int counter = 1; // app counter
        int a; //captures first random number
        int b;//captures the second random number
        Random randA; // random number for a
        Random randB;// random number for b
        List<MBlock> blockList = new List<MBlock>(); // creates a list of blocks
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Block_Load);  // Creates Block Objects and loads them to the app
            this.Load += new EventHandler(Form1_Load); // initializes all the variables that will be used in the app
            // Code for Mouse button functionality on click evernts
            //On enter button lights up
            //On leave it returns to normal state
            //On Down it changes color
            //On up it returns to normal state
            select_Btn.MouseEnter += new EventHandler(select_Btn_MouseEnter); 
            select_Btn.MouseLeave += new EventHandler(select_Btn_MouseLeave); 
            select_Btn.MouseDown += new MouseEventHandler(select_Btn_MouseDown); 
            select_Btn.MouseUp += new MouseEventHandler(select_Btn_MouseUp);
            prev_Btn.MouseEnter += new EventHandler(prev_Btn_MouseEnter);  
            prev_Btn.MouseLeave += new EventHandler(prev_Btn_MouseLeave);  
            prev_Btn.MouseDown += new MouseEventHandler(prev_Btn_MouseDown);  
            prev_Btn.MouseUp += new MouseEventHandler(prev_Btn_MouseUp);
            next_Btn.MouseEnter += new EventHandler(next_Btn_MouseEnter);
            next_Btn.MouseLeave += new EventHandler(next_Btn_MouseLeave);
            next_Btn.MouseDown += new MouseEventHandler(next_Btn_MouseDown);
            next_Btn.MouseUp += new MouseEventHandler(next_Btn_MouseUp);
            //End of Mouse button Code
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            // Form is loading with variables that will be used by the program
            randA = new Random(); a = randA.Next(0, 10);
            randB = new Random();
            // Used Case statements for variable creation. It was used twice in the program. Will need to clean up code and create a method that will run the code below
            switch (a)
            {
                case 1:
                    b = randB.Next(0, 9);
                    break;
                case 2:
                    b = randB.Next(0, 8);
                    break;
                case 3:
                    b = randB.Next(0, 7);
                    break;
                case 4:
                    b = randB.Next(0, 6);
                    break;
                case 5:
                    b = randB.Next(0, 5);
                    break;
                case 6:
                    b = randB.Next(0, 4);
                    break;
                case 7:
                    b = randB.Next(0, 3);
                    break;
                case 8:
                    b = randB.Next(0, 2);
                    break;
                default:
                    b = randB.Next(0, 1);
                    break;
            }
            pictureBox1.Image = blockList[a].block;
            pictureBox2.Image = blockList[b].block;
            textBox1.Text = " Math Block Probem #" + counter.ToString();
            answer = 10;
            textBox2.Text = answer.ToString();
            pictureBox4.Image = Properties.Resources.EGonzales; 
        }
        private void Block_Load(object sender, EventArgs e)
        {
            // Mblock Class Object Creation
            MBlock Block0 = new MBlock(0, Properties.Resources.blk_0); blockList.Add(Block0);
            MBlock Block1 = new MBlock(1, Properties.Resources.blk_1); blockList.Add(Block1);
            MBlock Block2 = new MBlock(2, Properties.Resources.blk_2); blockList.Add(Block2);
            MBlock Block3 = new MBlock(3, Properties.Resources.blk_3); blockList.Add(Block3);
            MBlock Block4 = new MBlock(4, Properties.Resources.blk_4); blockList.Add(Block4);
            MBlock Block5 = new MBlock(5, Properties.Resources.blk_5); blockList.Add(Block5);
            MBlock Block6 = new MBlock(6, Properties.Resources.blk_6); blockList.Add(Block6);
            MBlock Block7 = new MBlock(7, Properties.Resources.blk_7); blockList.Add(Block7);
            MBlock Block8 = new MBlock(8, Properties.Resources.blk_8); blockList.Add(Block8);
            MBlock Block9 = new MBlock(9, Properties.Resources.blk_9); blockList.Add(Block9);
            MBlock Block10 = new MBlock(10, Properties.Resources.blk_10); blockList.Add(Block10);
        }

        // Following Blocks of Code are all the button click events
        private void prev_Btn_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                pictureBox3.Image = blockList[index].block;
                answer = blockList[index].num;
                textBox2.Text = answer.ToString();
            }
            else
            {
                index = 10;
                pictureBox3.Image = blockList[index].block;
                answer = blockList[index].num;
                textBox2.Text = answer.ToString();
            }
        }

        private void next_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (index != blockList.Count + 1)
                {
                    index++;
                    pictureBox3.Image = blockList[index].block;
                    answer = blockList[index].num;
                    textBox2.Text = answer.ToString();
                }
            }
            catch (Exception ex)
            {
                index = 0;
                pictureBox3.Image = blockList[index].block;
                answer = blockList[index].num;
                textBox2.Text = answer.ToString();
            }
        }

        private void select_Btn_Click(object sender, EventArgs e)
        {
            int question = blockList[a].num + blockList[b].num;
            if (answer == question)
            {
                MessageBox.Show("Great Job! You got the answer right!", "Correct!", MessageBoxButtons.OK);
                if (firstTry == true)
                    correct++;
                counter++;
                textBox1.Text = " Math Block Probem #" + counter.ToString() ;
                int c = a;
                a = randA.Next(0, 10);
                if (c == a)
                    a = randA.Next(0, 10);
                //Second Switch code that could be rewritten as a method. will change in the next sprint.
                switch (a)
                {
                    case 1:
                        b = randB.Next(0, 9);
                        break;
                    case 2:
                        b = randB.Next(0, 8);
                        break;
                    case 3:
                        b = randB.Next(0, 7);
                        break;
                    case 4:
                        b = randB.Next(0, 6);
                        break;
                    case 5:
                        b = randB.Next(0, 5);
                        break;
                    case 6:
                        b = randB.Next(0, 4);
                        break;
                    case 7:
                        b = randB.Next(0, 3);
                        break;
                    case 8:
                        b = randB.Next(0, 2);
                        break;
                    default:
                        b = randB.Next(0, 1);
                        break;

                }
                pictureBox1.Image = blockList[a].block;
                pictureBox2.Image = blockList[b].block;
                firstTry = true;
            }
            else
            {
                if (firstTry == true)
                    firstTry = false;
                MessageBox.Show("Oops! Try Again!", "Incorrect!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void check_Btn_Click(object sender, EventArgs e)
        {
            data = counter - 1;
            MessageBox.Show("Currently you got " + correct + " out of " + data + " questions correct on the first try.", "Progress!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void select_Btn_MouseEnter(object sender, EventArgs e)
        {
            this.select_Btn.Image = ((System.Drawing.Image)(Properties.Resources.select_Btn_Hover));
        }

        private void select_Btn_MouseLeave(object sender, EventArgs e)
        {
            this.select_Btn.Image = ((System.Drawing.Image)(Properties.Resources.select_Btn));
        }

        private void select_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.select_Btn.Image = ((System.Drawing.Image)(Properties.Resources.select_Btn_Click));
        }

        private void select_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.select_Btn.Image = ((System.Drawing.Image)(Properties.Resources.select_Btn_Hover));
            this.select_Btn.Image = ((System.Drawing.Image)(Properties.Resources.select_Btn));
        }

        private void next_Btn_MouseEnter(object sender, EventArgs e)
        {
            this.next_Btn.Image = ((System.Drawing.Image)(Properties.Resources.next_Btn_Hover));
        }

        private void next_Btn_MouseLeave(object sender, EventArgs e)
        {
            this.next_Btn.Image = ((System.Drawing.Image)(Properties.Resources.next_Btn));
        }

        private void next_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.next_Btn.Image = ((System.Drawing.Image)(Properties.Resources.next_Btn__Click));
        }

        private void next_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.next_Btn.Image = ((System.Drawing.Image)(Properties.Resources.next_Btn_Hover));
        }

        private void prev_Btn_MouseEnter(object sender, EventArgs e)
        {
            this.prev_Btn.Image = ((System.Drawing.Image)(Properties.Resources.prev_Btn_Hover));
        }

        private void prev_Btn_MouseLeave(object sender, EventArgs e)
        {
            this.prev_Btn.Image = ((System.Drawing.Image)(Properties.Resources.prev_Btn));
        }

        private void prev_Btn_MouseDown(object sender, MouseEventArgs e)
        {
            this.prev_Btn.Image = ((System.Drawing.Image)(Properties.Resources.prev_Btn_Click));
        }

        private void prev_Btn_MouseUp(object sender, MouseEventArgs e)
        {
            this.prev_Btn.Image = ((System.Drawing.Image)(Properties.Resources.prev_Btn_Hover));
        }

    } // Code written by E. Gonzales 2018
}
