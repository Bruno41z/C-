using System;

namespace KolkoIKrzyzyk {
    class Program {
        static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int playerTurn = 1;

        static void Main(string[] args) {
            Console.WriteLine("Witaj w grze w kółko i krzyżyk!");

            do {
                Console.Clear();
                DisplayBoard();
                int choice;
                Console.WriteLine("Gracz {0}, wybierz pole: ", playerTurn % 2 == 0 ? 2 : 1);
                choice = int.Parse(Console.ReadLine()) - 1;

                if (board[choice] != 'X' && board[choice] != 'O') {
                    if (playerTurn % 2 == 0) {
                        board[choice] = 'O';
                        playerTurn++;
                    } else {
                        board[choice] = 'X';
                        playerTurn++;
                    }
                } else {
                    Console.WriteLine("To pole jest już zajęte! Wybierz inne.");
                    Console.ReadKey();
                }
            } while (!CheckForWin() && !CheckForDraw());

            Console.Clear();
            DisplayBoard();

            if (CheckForWin()) {
                int winningPlayer = playerTurn % 2 == 0 ? 1 : 2;
                Console.WriteLine("Gratulacje, gracz {0} wygrywa!", winningPlayer);
            } else {
                Console.WriteLine("Remis! Nikt nie wygrywa.");
            }

            Console.ReadLine();
        }

        static void DisplayBoard() {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
            Console.WriteLine("     |     |      ");
        }

        static bool CheckForWin() {
            return (board[0] == board[1] && board[1] == board[2]) ||
                   (board[3] == board[4] && board[4] == board[5]) ||
                   (board[6] == board[7] && board[7] == board[8]) ||
                   (board[0] == board[3] && board[3] == board[6]) ||
                   (board[1] == board[4] && board[4] == board[7]) ||
                   (board[2] == board[5] && board[5] == board[8]) ||
                   (board[0] == board[4] && board[4] == board[8]) ||
                   (board[2] == board[4] && board[4] == board[6]);
        }

        static bool CheckForDraw() {
            foreach (char c in board) {
                if (c != 'X' && c != 'O') {
                    return false;
                }
            }
            return true;
        }
    }
}
