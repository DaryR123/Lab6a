using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Using System.Linq");

double[] a=new double [7];
double[] b=new double[7];
double sum=0;


for (int i = 0; i <7; i++)
{
  Console.WriteLine("Enter temperature in celsuis");

  a[i] = Convert.ToInt32(Console.ReadLine());

  b[i] = (a[i]*9/5)+32;
  sum+=b[i];
}

Console.WriteLine("Temperature in fahrenheit");

Array.Reverse(b);
foreach(double item in b)
Console.WriteLine(item);
double average=sum/7;
Console.WriteLine("Average weekly temperature is " +average+"degree fahrenheit");

  }
}