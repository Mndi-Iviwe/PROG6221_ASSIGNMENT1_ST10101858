using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROG6221_ASSIGNMENT1_ST10101858
{
    internal class Ingredients
    {
        public int numIngredients;
        public string[] ingredientName = new string[15];
        public double[] ingredientQuantity = new double[15];
        public string[] measureUnit = new string[15];

        public Ingredients[] ingredients = new Ingredients[3];

        public void CaptureIngredients(int num)
        {
            int count = 0;
           
                for (int x = 0; x < num; x++)
                {

                    try
                    {
                        Console.WriteLine("\nEnter the Ingredient #{0} name: ", count + 1);
                        ingredientName[x] = Console.ReadLine();

                        Console.WriteLine("\nEnter the unit of measurement #{0}: ", count + 1);
                        measureUnit[x] = Console.ReadLine();

                        Console.WriteLine("\nEnter the quantity #{0} of the unit of measurement : ", count + 1);
                        ingredientQuantity[x] = Convert.ToDouble(Console.ReadLine());
                        count++;
                }
                    catch (Exception e)
                    {

                    Console.WriteLine("Wrong Input" + e); ;
                    }
                    
                }
      
        }

        public void HalfScaled()
        {
            int count = 0;
            double scale = 0.5;


            Console.WriteLine("\n Ingredients (half scaled): ");
            for (int x = 0; x < numIngredients; x++)
            {
                System.Console.WriteLine(ingredientQuantity[count] * scale + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }
        public void DoubleScaled()
        {

            int count = 0;
            int scale = 2;

            Console.WriteLine("\n Ingredients (double scaled): ");
            while (count < numIngredients)
            {
                System.Console.WriteLine(ingredientQuantity[count] * scale + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }
        public void TripleScaled()
        {
            int count = 0;
            int scale = 3;

            Console.WriteLine("\n Ingredients (triple scaled): ");
            while (count < numIngredients)
            {
                Console.WriteLine(ingredientQuantity[count] * scale + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }

        public void ScaleOption()
        {
            Steps steps = new Steps();
            int choice;

            try
            {
                Console.WriteLine("What Scaling do you wish to apply (enter choice)?\n" +
                    "1) Half Scaling\n" +
                    "2) Double Scaling\n" +
                    "3) Triple Scaling\n");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw e;
            }

            switch (choice)
            {
                case 1:
                    HalfScaled();
                    steps.PrintSteps();
                    break;
                case 2:
                    DoubleScaled();
                    steps.PrintSteps();
                    break;
                case 3:
                    TripleScaled();
                    steps.PrintSteps();
                    break;
                default:
                    break;
            }

        }

        public void PrintIngredientList()
        {
            int count = 0;

            Console.WriteLine("\n Ingredients: ");
            for (int x = 0; x < numIngredients; x++)
            {
                Console.WriteLine(ingredientQuantity[count] + " " + measureUnit[count] + " of " + ingredientName[count]);
                count++;
            }

        }
    }
}
