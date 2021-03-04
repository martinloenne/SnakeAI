using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeneticAlgorithmNS {
  class Program {

   // static int lastKeyPressed;

    // GAMLE MAIN, BRUGES IKKE!!!

      // Tag gamle snake game således kan spilles udover


    static void Main(string[] args) {





      /*
      // START OF NEURAL NETWORK TEST
      if(false) {
        // SET UP VARIABLES
        int action;

        SnakeGame snakeGame;
        SnakeSettings snakeSettings;

        int points = 0;
        int randomInt;

        // SET UP SETTINGS
        NetworkSettings networkSettings = new NetworkSettings(ProgramSettings.NUMBER_OF_INPUT_NEURONS, 
                                                              ProgramSettings.NUMBER_OF_HIDDEN_NEURONS, 
                                                              ProgramSettings.NUMBER_OF_OUTPUT_NEURONS.Length);

        double[] weights = new double[networkSettings.numberOfWeights];
        int[] array = new[] { 1, -1 };


        // ALL SET - NOW PLAY!
        // NEW GAME
        do {
          // Initialize random weights
          for(int i = 0; i < networkSettings.numberOfWeights; i++) {
            randomInt = ProgramSettings.RandomNumber.Next(0, 2);
            weights[i] = ProgramSettings.RandomNumber.NextDouble() * array[randomInt];
          }

          snakeSettings = new SnakeSettings(ProgramSettings.GRID_ROWS, ProgramSettings.GRID_COLUMNS, new Random(), 
                                            ProgramSettings.SPAWN_RANDOM_SNAKE);

          snakeGame = new SnakeGame(snakeSettings);
          // Get snake game grid for input to NN
          Field[,] grid = snakeGame.Grid;
          //int[] input = ConvertGridToInput(grid);
          //int[] input = ConvertGridToInput2(snakeGame.Grid, snakeGame.snake, snakeGame.food);
         // NeuralNetwork neuralNetwork = new NeuralNetwork(input, ProgramConstants.NUMBER_OF_OUTPUT_NEURONS, 
          //                                                networkSettings, weights);

          do {
            snakeGame.DisplayGrid();

            //input = ConvertGridToInput(grid);
            //input = ConvertGridToInput2(snakeGame.Grid, snakeGame.snake, snakeGame.food);
          
           // action = neuralNetwork.CalculateAction(input);

            snakeGame.UpdateGrid(action);
            grid = snakeGame.Grid;
            Thread.Sleep(50);

            Console.Clear();

          } while(snakeGame.IsAlive);
          points = snakeGame.Points;
        } while(points < 5);

        snakeGame.DisplayEndScreen(); // Show game over screen

        Console.Write("\nPress any key to exit...");
        Console.ReadKey();
      }

      // START OF SNAKE TEST      
      if(true) {
        //SnakeSettings snakeSettings = new SnakeSettings(ProgramSettings.GRID_ROWS, ProgramSettings.GRID_COLUMNS, new Random(), ProgramSettings.SPAWN_RANDOM_SNAKE);

        do {
          // DO NOT MESS WITH ORDER OF METHOD CALLS 
          SnakeGame snakeGame = new SnakeGame(snakeSettings);
          snakeGame.DisplayGrid();

          // Make thread which checks for keypress in infinite loop
          //Thread keyPressThread = new Thread(GetKeyPress);
          //keyPressThread.IsBackground = true; // Will close aut. when main exit
          //keyPressThread.Start(); // Uncomment if multithreading
          lastKeyPressed = ConvertConsoleKeyToInt(Console.ReadKey());
          snakeGame.UpdateGrid(lastKeyPressed);
          Console.Clear();
          while(snakeGame.IsAlive) {
            Console.WriteLine("Hej");
            Console.ReadKey();

            //Thread.Sleep(100); // Uncomment if multithreading
            lastKeyPressed = ConvertConsoleKeyToInt(Console.ReadKey()); // Comment if multithreading
            snakeGame.UpdateGrid(lastKeyPressed);
          }
          //keyPressThread.Abort(); // Kill thread
          Console.Clear();
          snakeGame.DisplayEndScreen();

          Console.Write("\nRetry (any key) or quit (enter)?");
        } while(Console.ReadKey().Key != ConsoleKey.Enter);
        // END OF SNAKE TEST
      }
     

      #endregion
    }





    static void GetKeyPress() {
      while(true) {
        lastKeyPressed = ConvertConsoleKeyToInt(Console.ReadKey());
      }
    }

    static int ConvertConsoleKeyToInt(ConsoleKeyInfo consoleKey) {
      int intKey = 0;
      // Check key pressed
      switch(consoleKey.Key) {
        case ConsoleKey.LeftArrow:
          intKey = 1;
          break;
        case ConsoleKey.RightArrow:
          intKey = 2;
          break;
        case ConsoleKey.UpArrow:
          intKey = 3;
          break;
        case ConsoleKey.DownArrow:
          intKey = 4;
          break;
        default:
          intKey = lastKeyPressed;
          break;
      }
      return intKey;
    }
  }
}
    
*/
      /*
      // HUSK SKAL PLACERES SOM METODE I AGENT
      // Convert grid 2D array to input 1D array
      public static int[] ConvertGridToInput(Field[,] grid) {

        int rows = grid.GetLength(0);
        int columns = grid.GetLength(1);

        int[] input = new int[rows * columns];
        int counter = 0;

        for(int i = 0; i < rows; i++) {
          for(int j = 0; j < columns; j++) {
            input[counter] = GetStateOfType(grid[i, j].GetType());
            counter++;
          }
        }
        return input;
      }
      */
      /*
      private static int GetStateOfType(Type type) {
        int state = 0;

        if(type == 
        
      
      (Food)) {
          state = ProgramConstants.STATE_FOOD;
        }
        else if(type == typeof(GridField)) {
          state = ProgramConstants.STATE_GRID_FIELD;
        }
        else if(type == typeof(SnakeHead)) {
          state = ProgramConstants.STATE_SNAKE_HEAD;
        }
        else if(type == typeof(SnakeBody)) {
          state = ProgramConstants.STATE_SNAKE_PART;
        }
        else if(type == typeof(Wall)) {
          state = ProgramConstants.STATE_WALL;
        }
        else {
          throw new Exception("Type undefined");
        }
        return state;
      }


    }
  }

    */

    }
  }
}