using System;

namespace StaticKeywordExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);

            Console.WriteLine($"Celsius {celsius}");
            Console.WriteLine($"Fahrenheit {fahrenheit}");

        }
    }
}
