using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Board
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public bool[,] BoardTab { get; set; }

        public Board(int height, int width)
        {
            this.Height = height;
            this.Width = width;
            BoardTab = new bool[width,height];

            for(int i=0; i < width; i++)
            {
                for(int j=0; j<height; j++)
                {
                    BoardTab[i,j] = new bool();
                }
            }
        }
    }
}
