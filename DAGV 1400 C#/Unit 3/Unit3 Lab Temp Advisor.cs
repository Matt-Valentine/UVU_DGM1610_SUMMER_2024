using System;
					
public class Program
{
	public void Main() {
		
		Console.WriteLine("Challenge: Temp Advisor");
		Console.WriteLine("Enter current temperature in degrees celsius:");
		
		int temperature = Convert.ToInt32(Console.ReadLine());
		
		if(temperature > 30){
			Console.WriteLine("Stay Hydrated, it's hot out! :)");
		} else {
			Console.WriteLine("Enjoy the weather! :)");
		}
	}
}