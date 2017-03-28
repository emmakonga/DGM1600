using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {
	public string[] names; 
	public string[] names2;  
	public string[] musicInfo; 
	public string[] furniture;
	public string[] sport;
	public string[] names1;
	public string[] seasons;
	public string[] weather;
	public string[] animationCourse;
	public string[] startCourse;
	public float[] grades;



	void Start () {
		
		//Start first example

		//Initializing the names string with a size of 4
		names = new string[4];
		//Setting names at index 0 equal to Emmanuel
		names[0]= "Emmanuel";
		//Setting names at index 1 equal to Spive
		names [1] = "Spive";
		//Setting names at index 2 equal to Samy
		names [2] = "Samy";	
		//Setting names at index 3 equal to John
		names [3] = "John";

		//Printing total number of names
		print("Total Names: " + names.Length);
		//Preparing to print all the names
		print ("The names are: ");
		//Looping through the names array and printing each name
		for (int i = 0; i < names.Length; i++) 
		{
			  print(names [i]);
		}
		//End first example


		//Start second example

		//Initializing the furniture array with a size of 3
		furniture = new string[3];
		//Setting furniture at index 0 equal to Sofa
		furniture [0] = "Sofa";
		//Setting furniture at index 1 equal to Table
		furniture [1] = "Table";
		//Setting furniture at index 2 equal to Wardrobe
		furniture [2] = "Wardrobe";

		//Printing the total pieces of furniture
		print("Total pieces of furniture: " + furniture.Length);
		//Preparing to list the furniture
		print("My furniture is: ");
		//Looping through the furniture array and printing each item
		for (int j = 0; j < furniture.Length; j++) 
		{
			print(furniture [j]);
		}
		//End second example

		//Start third example

		//Initializing the musicInfo with a size of 2
		musicInfo = new string[2];
		//Setting musicInfo at index 0 equal to "I've Got You Under My Skin";
		musicInfo [0] = "I've Got You Under My Skin";
		//Setting musicInfo at index 1 equal to Frank Sinatra
		musicInfo [1] = "Frank Sinatra";

		//Printing the current song which is from Frank Sinatra 
		print ("My current song is:");
		//Looping through the musicInfo array and printing the item
		for (int m = 0; m < musicInfo.Length; m++)
		{
			print (musicInfo[m]);
		}

		//End third example

		//Start fourth example

		//Initializing the sport array with a size of 4
		sport = new string[4];
		//Setting sport at index 0 equal to Soccer
		sport [0] = "Soccer";
		//Setting sport at index 1 equal to BasketBall
		sport [1] = "Basketball";
		//Setting sport at index 2 equal to Tenis
		sport [2] = "Tenis";
		//Setting sport at index 3 equal to Hand ball
		sport [3] = "Hand ball";
		//Printing the total number of sport 
		print("Total number of sport: " + sport.Length);
		print("My favorite sport is: ");
		//Looping through the integer 0 array and printing each sport
		for (int s = 0; s < sport.Length; s++) 
		{
			print(sport[s]);
		}
		//End fourth example

		//Start fifth example

		//Initializing the names1 array with a size of 4
		names1 = new string[4];
		//Setting names1 at index 0 equal to Dog
		names1 [0] = "Dog";
		//Setting names1 at index 1 equal to Cat
		names1 [1] = "Cat";
		//Setting names1 at index 2 equal to Chicken
		names1 [2] = "Chicken";
		//Setting names2 at index 3 equal to Duck
		names1 [3] = "Duck";

		//Printing the total number of animals 
		print("Total names of animals: " + names1.Length);
		print("These are domestic animals: ");
		//Looping through the names1 array and printing each animal
		for (int a = 0; a < names1.Length; a++) 
		{
			print(names1[a]);
		}
		//End fifth example


		//Start sixth example
		//Initializing the seasons array with a size of 4
		seasons = new string[4];
		//Setting seasons at index 0 equal to Spring
		seasons[0] = "Spring";
		//Setting seasons at index 1 equal to Summer
		seasons[1] = "Summer";
		//Setting seasons at index 2 equal to Fall
		seasons[2] = "Fall";
		//Setting seasons at index 3 equal to Winter
		seasons[3] = "Winter";
		//Printing the total number of seasons 
		print("Total number of seasons: " + seasons.Length);
		print("These are four seasons of the year: ");
		//Looping through the seasons array and printing each seasons
		for (int ss = 0; ss < seasons.Length; ss++) 
		{
			print(seasons[ss]);
		}
		//End sixth example

		//Start seventh example

		//Initializing the weather array with a size of 2
		weather = new string[2];
		//Setting seasons at index 0 equal to Snow and cold in north America
		weather [0] = "Snow and cold in north America";
		//Setting seasons at index 1 equal to Humidity and hot in south America
		weather [1] = "Humidity and hot in south America";
		//Printing the current weather in America 
		print ("Current weather in the Americas: ");
		//Looping through the weather array and printing each weather
		for (int w = 0; w < weather.Length; w++)
		{
			print (weather[w]);
		}

		//End seventh example

		//Start eight example
		//Initializing the animationCourse array with a size of 2
		animationCourse = new string[2];
		//Setting animationCourse at index 0 equal to Provide 2D basics
		animationCourse [0] = "Provide 2D basics";
		//Setting animationCourse at index 1 equal to Provide 3D basics
		animationCourse [1] = "Provide 3D basics";
		//Printing the Total Animation classes
		print("Total Animations classes:" + animationCourse.Length);
		print ("The courses are: ");
		//Looping through the AnimationCourse array and printing each course
		for (int c = 0; c < animationCourse.Length; c++)
		{
			print (animationCourse[c]);
		}

		//End eight example

		//Start ninth example
		//Initializing the startCourse array with a size of 
		startCourse = new string[2];
		//Setting the startCourse array at index 0 equal to Fall
		startCourse [0] = "Fall";
		//Setting the startCourse array at index 1 equal to Spring
		startCourse [1] = "Spring";
		//Printing the Total number of semesters
		print("All program courses:" + startCourse.Length);
		print ("Normal school semesters start: ");
		//Looping through the startCourse array and printing each semester

		for (int d = 0; d < startCourse.Length; d++)
		{
			print (startCourse [d]);
		}

		//End nineth example

		//Start tenth example

		//Initializing the grades array with a size of 5
		grades = new float[5];
		//Setting the grades array at index 0 equal to 76.5
		grades [0] = 76.5f;
		//Setting the grades array at index 1 equal to 85.0
		grades [1] = 85.0f;
		//Setting the grades array at index 2 equal to 80.75
		grades [2] = 80.75f;
		//Setting the grades array at index 3 equal to 95.0
		grades [3] = 95.0f;
		//Setting the grades array at index 4 equal to 97.5
		grades [4] = 97.5f;

		//Declaring a float variable for the sum of all the grades, initializing at 0
		float gradeTotal = 0f;

		//Printing the number of grades in the array
		print ("Number of test scores: " + grades.Length);
		//Preparing to list the grades
		print("The scores are: ");
		//Looping through the grades array and printing each grade
		for (int g = 0; g < grades.Length; g++)
		{
			//This prints the current grade
			print (grades [g]);
			//Adding the current grade to the gradeTotal variable
			gradeTotal += grades [g];
		}

		//Printing the average score by dividing the final gradeTotal value by the length of the grades array
		print ("The average score was: " + gradeTotal / grades.Length);



		//End tenth example

	}
}


	
