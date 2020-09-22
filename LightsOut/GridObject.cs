using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("GridCreatorTests")]
namespace LightsOut
{
    public class GridObject
    {
        public char[,] Grid { get; set; }

        public GridObject(int gridsize)
        {
            Grid = new char[gridsize, gridsize];
        }

        public void PopulateGrid()
        {
            Random random = new Random();
            
            for (int i = 0; i <= Grid.Length; i++)
            {
                for (int j = 0; j <= Grid.Length; j++)
                {
                    if (random.Next(0, 1) == 1)
                    {
                        Grid[i, j] = 'x';
                    }
                    else
                    {
                        Grid[i, j] = 'o';
                    }    
                }
            }
        }
    }
}
