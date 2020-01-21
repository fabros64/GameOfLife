using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        Board board;
        bool exit = false;

        public Form1()
        {
            InitializeComponent();
            board = new Board(10, 10);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            exit = true;
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                string path = saveFileDialog1.FileName;

                StartPosition startPosition = new StartPosition(board, path);
                startPosition.SavePositionToFile();
                MessageBox.Show("Saved Successfully");
            }           
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            exit = true;
            try
            {
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                {
                    string path = openFileDialog1.FileName;

                    StartPosition startPosition = new StartPosition(board, path);
                    board = startPosition.OpenPositionFromFile();

                    BoardGenerator.DrawBoard(board, this.mainPanel);

                    saveButton.Enabled = true;
                }

                generationButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Invalid File! Choose correct one");
            }
        }

        private void boardButton_Click(object sender, EventArgs e)
        {
            exit = true;
            if (minRb.Checked == true)
                board = new Board(10, 10);

            else if (midRb.Checked == true)
                board = new Board(10, 15);

            else
                board = new Board(15, 15);

            BoardGenerator.DrawBoard(board, this.mainPanel);
            saveButton.Enabled = true;
            generationButton.Enabled = true;           
        }

        private void generationButton_Click(object sender, EventArgs e)
        {
            Generation generation = new Generation(board);
            board = generation.GenerateNextGeneration();
            if (!AutomaticChBox.Checked)
            {               
                BoardGenerator.Board_Update();
            }
            else
            {
                exit = false;
                ThreadPool.QueueUserWorkItem(DoAutomaticWork);
                generationButton.Enabled = false;
            }
        }

        private void lockChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lockChBox.Checked == false)
            {
                mainPanel.Enabled = true;
            }
            else mainPanel.Enabled = false;
        }

        private void AutomaticChBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AutomaticChBox.Checked)
            {
                exit = false;                
            }
            else
            {
                exit = true;
                generationButton.Enabled = true;
            }
        }

        private void DoAutomaticWork(object state)
        {
            while (!exit)
            {
                Generation generation = new Generation(board);
                board = generation.GenerateNextGeneration();
                Thread.Sleep(350);
                BoardGenerator.Board_Update();               
            }
        }
    }
}
