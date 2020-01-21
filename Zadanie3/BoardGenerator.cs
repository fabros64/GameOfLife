using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    static class BoardGenerator
    {   
        private static Board Board { get; set; }
        private static Panel Panel { get; set; }

        public static void DrawBoard(Board board, Panel panel)
        {
            Board = board;
            Panel = panel;
            int width = panel.Width;
            int height = panel.Height;

            int buttonWidth = width / board.Width;
            int buttonHeight = height / board.Height;

            int size = Math.Min(buttonWidth, buttonHeight);

            panel.Controls.Clear();
            for (int x = 0; x < board.Width; x++)
            {
                System.Diagnostics.Debug.WriteLine(x);
                for (int y = 0; y < board.Height; y++)
                {
                    Button button = new Button();
                    button.Location = new Point(x * size, y * size);
                    button.Size = new Size(size, size);                   
                    button.Click += Button_Click;                    
                    button.BackColor = Color.LightGray;

                    button.Tag = new Cell(x, y);

                    if(board.BoardTab[x,y] == true)
                    {
                        button.BackColor = Color.Black;
                    }

                    panel.Controls.Add(button);                
                }
            }
        }

        public static void Board_Update()
        {
            IEnumerator buttonEnumerator;
            buttonEnumerator = Panel.Controls.GetEnumerator();           

            for (int x = 0; x < Board.Width; x++)
            {              
                for (int y = 0; y < Board.Height; y++)
                {
                   
                    buttonEnumerator.MoveNext();
                    Button button = buttonEnumerator.Current as Button;
                    if (Board.BoardTab[x, y] == true)
                    {
                        button.BackColor = Color.Black;
                    }
                    else
                        button.BackColor = Color.LightGray;                   
                }
            }
        }

        private static void Button_Click(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            Cell ButtonCell = button.Tag as Cell;
            if (button != null && button.Tag != null)
            {
                System.Diagnostics.Debug.WriteLine(ButtonCell);
            }

            if (button.BackColor == Color.Black)
            {
                button.BackColor = Color.LightGray;
                Board.BoardTab[ButtonCell.X, ButtonCell.Y] = false;
            }

            else
            {
                button.BackColor = Color.Black;
                Board.BoardTab[ButtonCell.X, ButtonCell.Y] = true;
            }
        }
    }
}
