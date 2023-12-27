// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using System;
using System.Runtime.CompilerServices;


Console.Write("Matrix size: ");
string matrix;
//matrix = Console.ReadLine();
//matrix = "5,5";
matrix="3,3";
Console.Write("Data: ");
string data;
//data = "5,5,5,5";
//data = "1,2,-2,1,0,1";
//data = "6,3,2,1";
data = "2,1,1,-2,1,0";
//data = Console.ReadLine();
Console.Write("Race 1 or 2: ");
string raceType;
//raceType = Console.ReadLine();
//raceType = "2";
raceType = "1";


string[] matrixResult = matrix.Split(",");


string[] dataResult = data.Split(",");
int[] dataResults = Array.ConvertAll(dataResult, s => int.Parse(s));

int coordinationX = 0;
int coordinationY = 0;
int locationX = 0;
int locationY = 0;
int resultX=0;
int resultY=0;

if (raceType == "1")
{

    Console.WriteLine("for human");
    for (int i = 0; i < dataResults.Length; i++)
    {
        
        if (i % 2 == 0)
        {
            int positiveX = Math.Abs(dataResults[i]);
            coordinationX += positiveX;
            if (Convert.ToInt32(matrixResult[0]) < coordinationX)
            {
                locationX = coordinationX % Convert.ToInt32(matrixResult[0])  ;
                resultX= locationX - 1;
            }
            else resultX = coordinationX;

        }
        else 
        {
            
            int positiveY = Math.Abs(dataResults[i]);
            coordinationY += positiveY;
            if (Convert.ToInt32(matrixResult[1]) < coordinationY)
            {
                locationY =     coordinationY % Convert.ToInt32(matrixResult[1]);
                resultY = locationY - 1;

            }
            else resultY = coordinationY;


            if (dataResults.Length>i)
            {
                
                Console.WriteLine("Report Path:\n" + resultX + " " +resultY);
            }
        }
        
    }
    Console.WriteLine("Report Actual Coordination:\n"+ resultX+ " "+resultY);
    
}
else
{
    
}





