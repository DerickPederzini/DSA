using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[][] board =
        {
            new[] {true, true, true},
            new[] {true, false, true},
            new[] {true, true, true}
        };

            int[][] path = new int[board.Length][];
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = new int[board[0].Length];
            }

            AllPathPrint("", board, 0, 0, path, 1);
        }

       
    static void AllPath(string p, bool[][] maze, int r, int c)
    {
        if (r == maze.Length - 1 && c == maze[0].Length - 1)
        {
            Console.WriteLine(p);
            return;
        }

        if (!maze[r][c])
        {
            return;
        }

        // Consider this block in the path
        maze[r][c] = false;

        if (r < maze.Length - 1)
        {
            AllPath(p + 'D', maze, r + 1, c);
        }

        if (c < maze[0].Length - 1)
        {
            AllPath(p + 'R', maze, r, c + 1);
        }

        if (r > 0)
        {
            AllPath(p + 'U', maze, r - 1, c);
        }

        if (c > 0)
        {
            AllPath(p + 'L', maze, r, c - 1);
        }

        // this line is where the function will be over
        // so before the function gets removed, also remove the changes that were made by that function
        maze[r][c] = true;
    }



    static void AllPathPrint(string p, bool[][] maze, int r, int c, int[][] path, int step)
        {
            if (r == maze.Length - 1 && c == maze[0].Length - 1)
            {
                path[r][c] = step;
                foreach (var arr in path)
                {
                    Console.WriteLine(string.Join(", ", arr));
                }
                Console.WriteLine(p);
                Console.WriteLine();
                return;
            }

            if (!maze[r][c])
            {
                return;
            }

            // Consider this block in the path
            maze[r][c] = false;
            path[r][c] = step;

            if (r < maze.Length - 1)
            {
                AllPathPrint(p + 'D', maze, r + 1, c, path, step + 1);
            }

            if (c < maze[0].Length - 1)
            {
                AllPathPrint(p + 'R', maze, r, c + 1, path, step + 1);
            }

            if (r > 0)
            {
                AllPathPrint(p + 'U', maze, r - 1, c, path, step + 1);
            }

            if (c > 0)
            {
                AllPathPrint(p + 'L', maze, r, c - 1, path, step + 1);
            }

            // this line is where the function will be over
            // so before the function gets removed, also remove the changes that were made by that function
            maze[r][c] = true;
            path[r][c] = 0;
        }
    }
}
