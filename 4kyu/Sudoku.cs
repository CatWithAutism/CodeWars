using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars._4kyu
{
    public class Sudoku
    {
        public static bool ValidateSolution(int[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                int[] first = new int[board.Length];
                int[] second = new int[board.Length];
                for (int j = 0; j < board.Length; j++)
                {
                    first[j] = board[i][j];
                    second[j] = board[j][i];
                }
                if (first.Distinct().Count() != board.Length || second.Distinct().Count() != board.Length)
                    return false;
            }

            for (int squareI = 0; squareI < board.Length; squareI += 3)
            {
                for (int squareJ = 0; squareJ < board.Length; squareJ += 3)
                {
                    List<int> flatSquare = new List<int>();
                    for (int i = squareI; i < squareI + 3; i++)
                    {
                        for (int j = squareJ; j < squareJ + 3; j++)
                        {
                            flatSquare.Add(board[i][j]);
                        }
                    }
                    if (flatSquare.Distinct().Count() != board.Length)
                        return false;
                }
            }

            return true;
        }
    }
}
