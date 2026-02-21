using System;
using System.Linq;

namespace SudokuApp.Service
{
    public class SudokuGenerator
    {
        private int[,] board = new int[9, 9];
        private readonly Random random = new();

        public void Generate()
        {
            FillBoard(0, 0);
            PrintBoard();
        }

        private bool FillBoard(int row, int col)
        {
            // Если дошли до конца (строка 9), поле заполнено
            if (row == 9) return true;

            // Вычисляем следующую ячейку
            int nextRow = (col == 8) ? row + 1 : row;
            int nextCol = (col == 8) ? 0 : col + 1;

            // Генерируем случайный список чисел от 1 до 9 для перебора
            var numbers = Enumerable.Range(1, 9).OrderBy(x => random.Next()).ToArray();

            foreach (int num in numbers)
            {
                if (IsSafe(row, col, num))
                {
                    board[row, col] = num;

                    if (FillBoard(nextRow, nextCol))
                        return true; // Рекурсивный успех

                    board[row, col] = 0; // Backtracking (откат)
                }
            }
            return false;
        }

        private bool IsSafe(int row, int col, int num)
        {
            for (int i = 0; i < 9; i++)
            {
                // Проверка строки, столбца и малого квадрата 3x3
                if (board[row, i] == num || board[i, col] == num ||
                    board[row - row % 3 + i / 3, col - col % 3 + i % 3] == num)
                    return false;
            }
            return true;
        }

        public void PrintBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0 && i != 0) Console.WriteLine("---------------------");
                for (int j = 0; j < 9; j++)
                {
                    if (j % 3 == 0 && j != 0) Console.Write("| ");
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
