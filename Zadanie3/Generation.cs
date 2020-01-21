using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Generation
    {
        private int[,] NeighboursTab { get; set; }
        private bool[,] NextGeneration { get; set; }
        private Board Board { get; set; }

        public Generation(Board board)
        {
            Board = board;

            NeighboursTab = new int[board.Width,board.Height];
            NextGeneration = board.BoardTab;

            for(int i=0; i < board.Width; i++)
            {
                for(int j=0; j < board.Height; j++)
                {
                    NeighboursTab[i, j] = 8;
                }
            }
        }

        private void CountNeighbours()
        {
            for(int x=0; x < Board.Width; x++)
            {
                for(int y=0; y < Board.Height; y++)
                {
                    if (y == 0)
                    {
                        NeighboursTab[x, y]--; NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                        if (!Board.BoardTab[x, y + 1]) NeighboursTab[x, y]--;
                        if (x == 0)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y + 1]) NeighboursTab[x, y]--;
                        }

                        else if (x == Board.Width - 1)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y + 1]) NeighboursTab[x, y]--;
                        }

                        else
                        {
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y + 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y + 1]) NeighboursTab[x, y]--;
                        }
                    }

                    else if(y == Board.Height - 1)
                    {
                        NeighboursTab[x, y]--; NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                        if (!Board.BoardTab[x, y - 1]) NeighboursTab[x, y]--;
                        if (x == 0)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y - 1]) NeighboursTab[x, y]--;
                        }

                        else if (x == Board.Width - 1)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y - 1]) NeighboursTab[x, y]--;
                        }

                        else
                        {
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y - 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y - 1]) NeighboursTab[x, y]--;
                        }
                    }

                    else
                    {
                        if (!Board.BoardTab[x, y - 1]) NeighboursTab[x, y]--;
                        if (!Board.BoardTab[x, y + 1]) NeighboursTab[x, y]--;
                        if (x == 0)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y + 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y - 1]) NeighboursTab[x, y]--;
                        }

                        else if (x == Board.Width - 1)
                        {
                            NeighboursTab[x, y]--; NeighboursTab[x, y]--; NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y - 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y + 1]) NeighboursTab[x, y]--;
                        }

                        else
                        {
                            if (!Board.BoardTab[x - 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y + 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x - 1, y - 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y + 1]) NeighboursTab[x, y]--;
                            if (!Board.BoardTab[x + 1, y - 1]) NeighboursTab[x, y]--;
                        }
                    }
                }
            }
        }

        public Board GenerateNextGeneration()
        {
            CountNeighbours();

            for(int i = 0; i < Board.Width; i++)
            {
                for(int j = 0; j < Board.Height; j++)
                {   
                   if(Board.BoardTab[i,j] == false && NeighboursTab[i,j] == 3)
                   {
                        NextGeneration[i, j] = true;
                    }
                   else if((Board.BoardTab[i,j] == true && NeighboursTab[i,j] == 3) 
                        || (Board.BoardTab[i,j] == true && NeighboursTab[i,j] == 2))
                    {
                        NextGeneration[i, j] = true;
                    }
                    else
                    {
                        NextGeneration[i, j] = false;
                    }
                }
            }

            Board.BoardTab = NextGeneration;
            return Board;
        }
        
    }
}
