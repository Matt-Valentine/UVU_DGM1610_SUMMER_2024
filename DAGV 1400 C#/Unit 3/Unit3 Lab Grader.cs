using System;
					
public class Program
{
	public void Main() {
		
		Console.WriteLine("Challenge 2: Exam Grader");
		Console.WriteLine("Enter Grade as 0-100");
		
		int score = Convert.ToInt32(Console.ReadLine());
		
		if(score >= 90 && score <= 100){
			Console.WriteLine("Grade: A - Superb!");
		} 
		else if (score >= 80 && score < 90){
			Console.WriteLine("Grade: B - Well Done!");
		}
		else if (score >= 70 && score < 80){
			Console.WriteLine("Grade: C - Nice Job!");
		}
		else if (score >= 60 && score < 70){
			Console.WriteLine("Grade: D - Nice Try");
		}
		else if (score >= 0 && score < 60) {
			Console.WriteLine("Grade: F - Needs Improvement");
		} else {
			Console.WriteLine("Invalid score. Enter score between 0-100");
		}
	}
}