﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TicTacToe
            Console.WriteLine("Welcome to Tic Tac Toe Game ");
            TicTacToe.CreateBoard();
            TicTacToe.PlayerInput();

            Console.ReadLine();
        }
    }
}
