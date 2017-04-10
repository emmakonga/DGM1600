using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function_Parameters : MonoBehaviour {

	public string myText = "Hello";
	public string myText2 = "Goodbye";
	public string[] names;
	public int health = 100;
	private int resetVal = 100;
	public string userName = "Admin";
	public List<string> animals;
	// Use this for initialization
	void Start () {
		names = new string[3];
		names[0] = "Dave";
		names[1] = "Mark";
		names[2] = "George";
		//Calls printText function with myText as a parameter
		printText (myText);
		//Calls printText2 function with myText and myText2 as parameters
		printText2 (myText, myText2);
		//Calls ListNames function with names array as parameter
		ListNames (names);
		//Calls AddHealth function with int 50 parameter
		AddHealth(50);
		//Calls SubtractHealth function with int 25 parameter
		SubtractHealth (25);
		//Calls ResetHealth function with resetVal variable
		ResetHealth (resetVal);
		//Calls ResetUserName function with parameter "Batman"
		ResetUserName ("Batman");
		//Calls AddItem function with parameter "Cat"
		AddItem ("Cat");
		//Calls AddItem function with parameter "Dog"
		AddItem ("Dog");
		//Calls AddItem function with parameter "Pig"
		AddItem ("Pig");
		//Calls RemoveItem function with parameter "Pig"
		RemoveItem ("Pig");
		//Calls SearchList function with parameter "Dog"
		SearchList ("Dog");
		//Calls SearchList function with parameter "Elephant"
		SearchList ("Elephant");
	}

	//Example 1
	//Creates a function that takes a string parameter
	void printText(string text)
	{
		//prints the string
		print (text);
	}

	//Example 2
	//Creates a function that takes 2 string parameters
	void printText2 (string text, string text2)
	{
		//prints the strings together
		print (text + " " + text2);
	}

	//Example 3
	//Creates a function that takes a string array parameter
	void ListNames(string[] names)
	{
		//Prints the names in the array
		print("Names: ");
		for (int i = 0; i < names.Length; i++) 
		{
			print (names [i]);
		}



	}


	//Example 4
	//Creates a function that takes a integer parameter
	void AddHealth (int h)
	{
		//Adds int parameter to health variable
		health += h;
		//prints new health
		print (health);
	}
		//End example 4	

	//Example 5
	//Creates a function that takes an int parameter
	public void SubtractHealth(int h)
	{
		//Subtracts parameter from health variable
		health -= h;
		//prints new health
		print (health);
	}
	//End example 5

	//Example 6
	//Creates a function that takes an int parameter
	public void ResetHealth(int resetVal)
	{
		//Sets health variable equal to the reset value parameter
		health = resetVal;
		//prints new health
		print ("Resetting health: " + health);
	}
	//End example 6

	//Example 7
	//Creates a function that takes a string parameter
	public void ResetUserName(string newName)
	{
		//Sets username variable to new name
		userName = newName;
		//prints updated userName variable
		print ("New username: " + userName);
	}
	//End exampl 7

	//Example 8
	//Creates a function that takes a string parameter
	public void AddItem(string item)
	{
		//If animals list is empty
		if (animals.Count == 0) 
		{
			//print no animals
			print ("No animals");
		}
		//Loops through animals list and prints all animals
		for (int i = 0; i < animals.Count; i++) 
		{
			print (animals [i]);
		}
		print ("Adding an animal...");
		//Adds parameter to list
		animals.Add (item);
		print ("My animals:");
		//Loops and prints updated animals list
		for (int i = 0; i < animals.Count; i++) 
		{
			print (animals [i]);
		}
	}
	//End example 8

	//Example 9
	//Creates a function that takes a string parameter
	public void RemoveItem(string item)
	{
		//If animals list is empty
		if (animals.Count == 0) 
		{
			//print no animals
			print ("No animals");
		}
		//Loops through animals list and prints all animals
		for (int i = 0; i < animals.Count; i++) 
		{
			print (animals [i]);
		}
		print ("Removing an animal...");
		//Removes parameter from list
		animals.Remove (item);
		print ("My animals:");
		//Loops and prints updated animals list
		for (int i = 0; i < animals.Count; i++) 
		{
			print (animals [i]);
		}

	}
	//End example 9

	//Example 10
	//Creates a function that takes a string parameter
	public void SearchList(string searchItem)
	{
		//If search item is in list
		if (animals.Contains (searchItem)) {
			//print that animal is in list
			print (searchItem + " is in the list.");
		} else 
		{
			//otherwise print that animal not in list
			print(searchItem + " is not in the list.");
		}
	}

	//End example 10
}
