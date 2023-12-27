using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Alien : Player, IPlay
    {
        public void Play(string[] matrixResult, string[] dataResult)
        {
            int[] dataResults = Array.ConvertAll(dataResult, s => int.Parse(s));
            Console.WriteLine("for alien");
            for (int i = 0; i < dataResults.Length; i++)
            {

                if (i % 2 == 0)
                {
                    int positiveX = Math.Abs(dataResults[i]);
                    coordinationX += positiveX;
                    if (Convert.ToInt32(matrixResult[0]) < coordinationX)
                    {
                        locationX = coordinationX % Convert.ToInt32(matrixResult[0]);
                        resultX = locationX - 1;
                    }
                    else resultX = coordinationX;

                }
                else
                {

                    int positiveY = Math.Abs(dataResults[i]);
                    coordinationY += positiveY;
                    if (Convert.ToInt32(matrixResult[1]) < coordinationY)
                    {
                        locationY = coordinationY % Convert.ToInt32(matrixResult[1]);
                        resultY = locationY - 1;

                    }
                    else resultY = coordinationY;


                    if (dataResults.Length > i)
                    {

                        Console.WriteLine("Report Path:\n" + resultY + " " + resultX);
                    }
                }

            }
            Console.WriteLine("Report Actual Coordination:\n" + resultY + " " + resultX);

        }
    }
}
