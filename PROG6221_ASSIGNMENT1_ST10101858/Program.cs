using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ASSIGNMENT1_ST10101858
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ingredients ingredients = new Ingredients();
            Steps steps = new Steps();

            //Start-up Greeting
            Console.WriteLine("\t\t\t\t Welcome To Sanele's Recipe app!!!\n\n");
            Console.WriteLine("Feel free to write in your most delicious traditional or favorite meal");
            Console.WriteLine("******************** A Recipe Must Be Recorded before Scaling ******************\n\n");


            //Capture Ingredients
            Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
            ingredients.numIngredients = Convert.ToInt32(Console.ReadLine());
            ingredients.CaptureIngredients(ingredients.numIngredients);


            Console.WriteLine("\nHow Many Steps to Complete the Recipe? >>");
            steps.NumSteps = Convert.ToInt32(Console.ReadLine());
            steps.CaptureSteps(steps.NumSteps);

            //Print result
            ingredients.PrintIngredientList();
            steps.PrintSteps();
            RecipeOptions();

            //present options
            void RecipeOptions()
            {
                int option;

                do
                {
                    try
                    {
                        Console.WriteLine("\nWhat Would you like to do?(enter choice)\n" +
                                       "1) Reset Recipe\n" +
                                       "2) Scale Recipe\n" +
                                       "3) Enter New Recipe\n" +
                                       "4) End Program\n");
                        option = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }

                    switch (option)
                    {
                        case 1:
                            ingredients.PrintIngredientList();
                            steps.PrintSteps();
                            RecipeOptions();
                            break;
                        case 2:
                            ingredients.ScaleOption();
                            RecipeOptions();
                            break;
                        case 3:
                            Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
                            ingredients.numIngredients = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nHow Many Ingredients in the Recipe? >>");
                            ingredients.CaptureIngredients(ingredients.numIngredients);
                            Console.WriteLine("\nHow Many Steps to Complete the Recipe? >>");
                            steps.CaptureSteps(steps.NumSteps);

                            ingredients.PrintIngredientList();
                            steps.PrintSteps();
                            RecipeOptions();
                            break;
                    }

                } while (option != 4);
            }
        }
    }
}
