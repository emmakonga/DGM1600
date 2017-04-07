using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void_Function : MonoBehaviour {
	//Declares public int variable
	public int num1 = 5;
	//Declares public int variable
	public int num2 = 3;
	//Declares public int variable
	public int num3 = 15;
	//Declares public array of strings called animals
	public string[] animals; 
	//Declares public string
	public string text = "Bonjours";
	//Declares public int variable
	public int num4 = 20;
	//Declares public array of strings called cars
	public string[] cars; 
	//Declares public int variable
	//Declares public string
	public string text1 = "Hello World";

	public List<string> furniture;

	void Start()
	{
		//Initializes array to size 3
		animals = new string[3];
		//Assigns animals to the array
		animals[0] = "Cat";
		animals[1] = "Dog";
		animals[2] = "Sheep";
		//Done assigning animals

		//Initializes array to size 3
		cars = new string[2];
		//Assigns cars to the array
		cars[0] = "Nissan";
		cars[1] = "Toyota";
		//Done assigning cars

		//Calls the "SayHello" function
		SayHello ();
		//Calls the "AddNumbers" function
		AddNumbers (num1, num2);
		//Calls the "Average" function
		Average ();
		//Calls the "Subtract" function
		Subtract (num3, num1);
		//Calls the "ListAnimals" function
		ListAnimals (animals);
		//Calls the "Bonjours" function
		Bonjours();
		//Calls the "MultiplyNumbers"function
		MultiplyNumbers(num1, num2, num3, num4);
		//Calls the "ListCars" function
		ListCars (cars);
		//Calls the "Hello World" function
		HelloWorld ();
		FurnitureList (furniture);
	}



	//Start first example

	//Creates a void function called SayHello
	void SayHello ()
	{
		//prints "Hello"
		print ("Hello!");
	}
	//End first example

	//Start second example

	//Creates a void function called AddNumbers that takes 2 int parameters
	void AddNumbers(int a, int b)
	{
		//Declares temporary int variable sum
		int sum;
		//Sets sum equal to the sum of a + b
		sum = a + b;
		//Prints the sum
		print ("Sum: " + sum);
	}
	//End second example

	//Start third example
	//Creates a void function called Average
	void Average()
	{
		//Declares float variable mean equal to num1 + num2 / 2
		float mean = num1 + num2 / 2;
		//Prints the average
		print ("Average: " + mean);
	}
	//End third example

	//Start fourth example
	//Creates a void function called Subtract that takes 2 int parameters
	void Subtract(int a, int b)
	{
		//Declares int variable diff
		int diff;
		//sets diff equal to a - b
		diff = a - b;
		//Prints difference
		print ("Difference: " + diff);
	}
	//End fourth example

	//Start fifth example
	//Creates a void function called ListAnimals that takes a string[] parameter
	void ListAnimals(string[] myArray)
	{
		print ("My Animals: ");
		//Loops through array passed into function
		for (int i=0; i<myArray.Length; i++)
		{
			//Prints the animal in each array element
			print(myArray[i]);
		}
	}
	//End fifth example

	//Start sixth example

	//Creates a void function called Bonjours
	void Bonjours ()
	{
		//prints "Bonjours"
		print ("Bonjours");
	}
	//End sixth example

	//Start seventh example
	//Creates a void function called MultiplyNumbers that takes 4 int parameters
	void MultiplyNumbers(int c, int d, int e, int f)
	{
		//Declares int variable sum
		int produit;
		//sets sum equal to c * d * e
		produit = c * d * e * f;
		//Prints difference
		print ("Produit: " + produit);
	}
	//End seventh example

	//Start eigth example
	//Creates a void function called ListCars that takes a string[] parameter
	void ListCars(string[] myArray)
	{
		print ("My Cars: ");
		//Loops through array passed into function
		for (int i=0; i<myArray.Length; i++)
		{
			//Prints the animal in each array element
			print(myArray[i]);
		}
	}
	//End eigth example

	//Start ninenth example

	//Creates a void function called "Hello World"
	void HelloWorld ()
	{
		//prints "Hello World"
		print ("HelloWorld");
	}
	//End ninenth example

	//start tenth example


	////Creates a void function called ArrayList that takes a string[] parameter
	void FurnitureList (List<string> myList)
	{
		//Adding items to List
		myList.Add ("Chair");
		myList.Add ("Bed");
		myList.Add ("Sofa");
		myList.Add ("Table");
		print ("My furniture: ");
		//Loop through list and print furniture items
		for (int i = 0; i < myList.Count; i++)
		{
			print(myList[i]);
		}
		print ("Adding Wardrobe to list...");
		print ("Removing chair from list...");
		//Add wardrobe to list
		myList.Add ("Wardrobe");
		//Remove Chair from list
		myList.Remove("Chair");
		//Loop through and print new list
		print("New furniture list: ");
		for (int i = 0; i < myList.Count; i++)
		{
			print(myList[i]);
		}
			
	}

}

	//end tenth example

