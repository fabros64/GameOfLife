using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class StartPosition
    {
        private Board StartBoard { get; set; }
        FileStream File { get; set; }

        public StartPosition(Board board, string path)
        {
            StartBoard = board;
            File = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        public void SavePositionToFile()
        {
            StreamWriter positionWriter = new StreamWriter(File);
            positionWriter.WriteLine(StartBoard.Width + " " + StartBoard.Height);          
            for(int i=0; i < StartBoard.Width; i++)
            {                
                for(int j=0; j<StartBoard.Height; j++)
                {
                    positionWriter.Write(StartBoard.BoardTab[i, j] + " ");
                }
                positionWriter.WriteLine();
            }
            positionWriter.Close();
            File.Close();           
        }

        public Board OpenPositionFromFile()
        {
            StreamReader positionReader = new StreamReader(File);
            string[] sizesOfBoard = positionReader.ReadLine().Split(new char[] { ' ' });
            int width = int.Parse(sizesOfBoard[0]);
            int height = int.Parse(sizesOfBoard[1]);
            StartBoard = new Board(height, width);

            int X = 0;

            while(!positionReader.EndOfStream)
            {

                string[] tabSingleLineValues = positionReader.ReadLine().Split(new char[] { ' ' });
                for (int Y = 0; Y < StartBoard.Height; Y++)
                {
                    StartBoard.BoardTab[X, Y] = bool.Parse(tabSingleLineValues[Y]);
                }
                X++;
            }
            positionReader.Close();
            File.Close();

            return StartBoard;
        }
    }
}
