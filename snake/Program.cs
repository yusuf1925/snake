// See https://aka.ms/new-console-template for more information


using Microsoft.VisualBasic;
using snake;
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
data = "1,2,-2,1,0,1";
//data = "6,3,2,1";
//data = "2,1,1,-2,1,0";
//data = Console.ReadLine();
Console.Write("Race 1 or 2: ");
string raceType;
//raceType = Console.ReadLine();
raceType = "2";
//raceType = "1";


string[] matrixResult = matrix.Split(",");
string[] dataResult = data.Split(",");
int[] dataResults = Array.ConvertAll(dataResult, s => int.Parse(s));



if (raceType == "1")
{
    Human human = new Human();
    human.Play(matrixResult,dataResult);
}
else
{
    Alien alien = new Alien();
    alien.Play(matrixResult, dataResult);
}





