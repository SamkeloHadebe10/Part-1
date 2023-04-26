using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10133296_Prog_part_1
{
    class Ingredient
    {
        class Program
        {
            static void Main(string[] args)
            {
                // new instance of the Recipe class
                Recipe recipe = new Recipe();

                // infinite loop that displays a menu of options to the user
                while (true)
                {
                    Console.WriteLine("***********************************************\n" +
                                     "Recipe Application\n" +
                                     "***********************************************\n" +
                                     "\n" +
                                     "(A) Press (1) to enter the details of your recipe.\n" +
                                    "(B) Press (2) to scale your recipe.\n" +
                                     "(C) Press (3) to delete your recipe.\n" +
                                     "(D) Press (4) to Reset to the initial values.\n" +
                                     "(E) Press (5) to display the recipe.\n" +
                                     "(F) Press (6) to exit the application.\n" +
                                     "\n" +
                                     "***********************************************\n");

                    // Prompt the user to choose an option
                    Console.WriteLine("Choose from list above to continue ");
                    int choice = int.Parse(Console.ReadLine());

                    // Based on the user's choice, a method will be called from the Recipe class 
                    if (choice == 1)
                    {
                        recipe.EnterDetails();
                    }

                    else if (choice == 2)
                    {
                        Console.Write("Enter scaling factor: ");
                        double factor = double.Parse(Console.ReadLine());
                        recipe.ScaleRecipe(factor);
                    }

                    else if (choice == 3)
                    {
                        recipe.ClearData();
                    }

                    else if (choice == 4)
                    {
                        recipe.ResetQuantities();
                    }

                    else if (choice == 5)
                    {
                        recipe.DisplayRecipe();
                    }

                    else if (choice == 6)
                    {
                        // Exits the loop and ends the program
                        break;
                    }

                }
                }
            }
        }
    }


