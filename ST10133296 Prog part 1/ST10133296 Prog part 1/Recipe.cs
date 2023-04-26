using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10133296_Prog_part_1
{
    class Recipe
    {
        // private fields to store recipe information
        private int numIngredients;
        private List<string> ingredientNames;
        private List<double> ingredientQuantity;
        private List<string> ingredientUnits;
        private int numSteps;
        private List<string> steps;

        // Constructor that initializes the private fields as empty lists
        public Recipe()
        {
            ingredientNames = new List<string>();
            ingredientQuantity = new List<double>();
            ingredientUnits = new List<string>();
            steps = new List<string>();
        }

        // Method that prompts the user to enter details for the recipe and stores them in the private fields
        public void EnterDetails()
        {
            Console.WriteLine("Enter the number of ingredients for your recipe ");
            numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter the name of ingredient {i + 1}: ");
                string name = Console.ReadLine();
                ingredientNames.Add(name);

                Console.WriteLine($"Enter the quantity of {name} ");
                double quantity = double.Parse(Console.ReadLine());
                ingredientQuantity.Add(quantity);

                Console.WriteLine($"Enter the unit of measurement for {name} (l or ml or g or kg) ");
                string unit = Console.ReadLine();
                ingredientUnits.Add(unit);
            }

            Console.WriteLine("Enter the number of steps on your recipe ");
            numSteps = int.Parse(Console.ReadLine());

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}");
                string step = Console.ReadLine();
                steps.Add(step);
            }
        }

        // Method that displays the recipe in a formatted manner
        public void DisplayRecipe()
        {
            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n" +
                              " Ingredients on your Recipe\n" +
                               "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"{ingredientQuantity[i]} {ingredientUnits[i]} {ingredientNames[i]}");
            }

            Console.WriteLine("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n" +
                              "Steps to take on your Recipe\n" +
                                "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^\n");

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        // Method that scales the recipe ingredients by a factor provided by the user
        public void ScaleRecipe(double factor)
        {
            for (int i = 0; i < numIngredients; i++)
            {
                ingredientQuantity[i] *= factor;
            }
        }

        // Method that resets the recipe ingredient quantities to half of their current values
        public void ResetQuantities()
        {
            for (int i = 0; i < numIngredients; i++)
            {
                ingredientQuantity[i] /= 2;
            }
        }

        // Method that clears all recipe data and resets all private fields to their default values
        public void ClearData()
        {
            numIngredients = 0;
            ingredientNames.Clear();
            ingredientQuantity.Clear();
            ingredientUnits.Clear();
            numSteps = 0;
            steps.Clear();
        }
    }
}
