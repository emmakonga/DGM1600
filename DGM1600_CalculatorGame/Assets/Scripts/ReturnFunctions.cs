using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour {

	//Variable declarations
	public int addAmount = 5;
	public bool snowed = true;
	public float a = 2.5f;
	public float b = 10f;
	public string[] animals;
	public GameObject cube;
	private string charName = "Player";
	public string newName = "Mario";
	public float[] numbers;

	// Use this for initialization
	void Start () {
		//Initialze arrays
		animals = new string[7];
		animals[0] = "Frog";
		animals[1] = "Duck";
		animals[2] = "Snake";
		animals[3] = "Horse";
		animals[4] = "Lion";
		animals[5] = "Bear";
		animals[6] = "Bee";

		numbers = new float[5];
		numbers [0] = 1.5f;
		numbers [1] = 2f;
		numbers [2] = 3.5f;
		numbers [3] = 7f;
		numbers [4] = 9.75f;
		//End Initialize arrays

		//Assigns variable to result of myInt function using addAmount as parameter
		int resultInt = myInt (addAmount);
		print (resultInt);

		//Assigns variable to result of CheckSpringWeather function using snowed bool as parameter
		bool result = CheckSpringWeather (snowed);

		//Print answer depending on result
		if (result == true) {
			print ("It snowed");
		} else if (result == false) 
		{
			print ("It didn't snow");
		}

		//Assigns variable to result of Multiply function using a and b as parameters
		float multResult = Multiply (a, b);
		print ("Product: " + multResult);

		//Assigns variable to result of Divide function using a and b as parameters
		float divResult = Divide (a, b);
		print ("Quotient: " + divResult);

		//Assigns variable to result of Add function using a and b as parameters
		float addResult = Add (a, b);
		print ("Sum: " + addResult);

		//Assigns variable to result of Subtract function using a and b as parameters
		float subResult = Subtract (a, b);
		print ("Difference: " + subResult);

		//Assigns variable to result of FillList function using animals as parameter
		List<string> animalList = FillList (animals);

		//Loops through and prints list
		for (int i = 0; i < animalList.Count; i++) 
		{
			print (animalList [i]);
		}

		//Assigns variable to result of CreateCubes function
		List<GameObject> cubeList = CreateCubes ();
		//Loops through and prints cubes in list
		for (int i = 0; i < cubeList.Count; i++) 
		{
			print (cubeList [i] + " "+  i);
		}

		//Assigns variable to result of ChangeCharacterName function using newName as parameter
		string updatedName = ChangeCharacterName (newName);
		print ("Character name is now: " + updatedName);

		//Assigns variable to result of Average function using numbers array as parameter
		float myAverage = Average (numbers);
		print ("Average: " + myAverage);
	}

	//Example 1
	//Creates a function that returns an int and takes an int parameter
	public int myInt(int i)
	{
		return i + 5;
	}
	//End example 1

	//Example 2
	//Creates a function that returns a bool and takes a bool parameter
	public bool CheckSpringWeather (bool snowed)
	{
		if(snowed)
			return true;
		else
			return false;
	}

	//Example 3
	//Creates a function that returns a float and takes 2 float parameters
	public float Multiply(float a, float b)
	{
		//Multiplies parameters and assigns to variable
		float result = a * b;
		return result;
	}

	//Example 4
	//Creates a function that returns a float and takes 2 float parameters
	public float Divide(float a, float b)
	{
		//Divides parameters and assigns to variable
		float result = a / b;
		return result;
	}

	//Example 5
	//Creates a function that returns a float and takes 2 float parameters
	public float Add(float a, float b)
	{
		//Adds parameters and assigns to variable
		float result = a + b;
		return result;
	}

	//Example 6
	//Creates a function that returns a float and takes 2 float parameters
	public float Subtract(float a, float b)
	{
		//Subtracts parameters and assigns to variable
		float result = a - b;
		return result;
	}

	//Example 7
	//Creates a function that returns a List of strings and takes string List parameter
	public List<string> FillList(string[] myAnimals)
	{
		//Creates temporary List
		List<string> myList = new List<string>();
		//Loops through array items and adds each to List
		for (int i = 0; i < myAnimals.Length; i++) 
		{
			myList.Add (myAnimals [i]);
		}
		//Returns List
		return myList;
	}

	//Example 8
	//Creates a function that returns a List of GameObjects and takes no parameters
	public List<GameObject> CreateCubes()
	{
		//Creates temporary List
		List<GameObject> myList = new List<GameObject>(); 
		//Generates random number between 5 and 10
		float randNum = Mathf.Floor (Random.Range (5f, 10f));
		//Loops thround random range and Instantiates cubes and adds those cubes to a List
		for (int i = 0; i < randNum; i++) 
		{
			Instantiate (cube, transform.position, Quaternion.identity);
			myList.Add (cube);
		}
		//Returns List
		return myList;
	}

	//Example 9
	//Creates a function that returns a string and takes a string parameter
	public string ChangeCharacterName(string newName)
	{	
		//Print current name
		print ("Current name: " + charName);
		print ("Changing to new name (" + newName + ")...");
		//Changes name
		string name = newName;
		//Returns new name
		return name;
	}

	//Example 10
	//Creates a function that returns a float and takes float array parameter
	public float Average(float[] numbers)
	{
		//Creates a float variable for sum
		float sum = 0f;
		//Loops through and adds each item of array together
		for (int i = 0; i < numbers.Length; i++) 
		{
			sum += numbers [i];
		}
		//Divides sum by number of items in array to get average
		float avg = sum / numbers.Length;
		//Returns average
		return avg;
	}
}
