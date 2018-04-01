using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Don't let the machines win. You are humanity's last hope...
 **/
class Player
{
    static void Main(string[] args)
    {
        int xSize = int.Parse(Console.ReadLine()); // the number of cells on the X axis
        int ySize = int.Parse(Console.ReadLine()); // the number of cells on the Y axis
        Console.Error.WriteLine("Qtd de colunas: " + xSize);
        Console.Error.WriteLine("Qtd de linhas: " + ySize);
        string[,] grid = new string[xSize, ySize];
        
        for (int y = 0; y < ySize; y++)
        {
            string line = Console.ReadLine();   // xSize characters, each either 0 or .
            for(int x = 0; x < xSize; x++)
            {
                grid[x,y] = line[x].ToString();
                
            }
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        for (int y = 0; y < ySize; y++)
        {
            for(int x = 0; x < xSize; x++)
            {
                bool haveXNeighbour = false;
                bool haveYNeighbour = false;
                int xNeighbour = 0;
                int yNeighbour = 0;
                string output = x + " " + y + " ";
                
                Console.Error.WriteLine(" -- nova celula --");
                Console.Error.WriteLine("grid[" + x + "," + y + "] = " + grid[x, y]);
                
                // if the current point dsnt have energy (not a node)
                if(grid[x,y] == ".") continue;
                
                if((x+1) < xSize){
                    Console.Error.WriteLine("direita grid[" + (x+1) + "," + y + "] = " + grid[x+1, y]);

                    // if the right neighbour have energy
                    for(xNeighbour = x+1; xNeighbour < xSize; xNeighbour++)
                    {
                        if((xNeighbour) < xSize && grid[xNeighbour, y] == "0")
                        {
                            haveXNeighbour = true;
                            break;
                        }
                    }

                }
                if((y+1) < ySize){
                    Console.Error.WriteLine("baixo grid [" + x + "," + (y+1) + "] = " + grid[x, y+1]);

                    // if the right neighbour have energy
                    for(yNeighbour = y+1; yNeighbour < ySize; yNeighbour++)
                    {
                        if((yNeighbour) < ySize && grid[x, yNeighbour] == "0")
                        {
                            haveYNeighbour = true;
                            break;
                        }
                    }
                }

                if(haveXNeighbour)
                {
                    output += (xNeighbour) + " " + y + " ";
                }else{
                    output += "-1 -1 ";
                }
                
                if(haveYNeighbour)
                {
                    output += x + " " + yNeighbour;
                }else{
                    output += "-1 -1 ";
                }
                
                Console.WriteLine(output);
                Console.Error.WriteLine(output);
                
            }
        }
        // Three coordinates: a node, its right neighbor, its bottom neighbor
    }
}