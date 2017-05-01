using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach_Loops : MonoBehaviour
{
	string[] strings = new string[4];
	public List<GameObject> cylList;
	public List<GameObject> cubeList;
	public List<GameObject> sphereList;
	public List<GameObject> capsuleList;
	string[] strings1 = new string[3];
	public List<string> animals;
	string[] arr = new string[5];
	public List<string> names;
	public List<string> names1;
	public List<string> names2;


	// Use this for initialization
	void Start ()
	{
		checkData ();
		checkData2 ();
		checkData3 ();
		checkData4 ();

		// start first example 
		strings [0] = "First string";
		strings [1] = "Second string";
		strings [2] = "Third string";
		strings [3] = "Fourth string";
		{
			foreach (string item in strings)
				print (item);
		}
		//end first example

		// start second example 
		strings1 [0] = "Cat";
		strings1 [1] = "Dog";
		strings1 [2] = "Horse";
		foreach (string pet in strings1) {	

			print (pet);
		}
		//end second example

		// start third example 
		animals.Add ("Rat");
		animals.Add ("Lion");
		animals.Add ("Monkey");
		foreach (string animal in animals) {
			print (animal);
		}
	
		//end third example

		// start fourth example 
		arr [0] = "Spive";
		arr [1] = "Assani";
		arr [2] = "Tayari";
		arr [3] = "Rene";
		arr [4] = "Amisi";
		foreach (string name in arr) {
			print (name);
		}

		//end fourth example

		// start fifth example 
		names = new List<string> () { "Marc", "John", "Mary" };
		foreach (string name in names) {	
			print (name);
		}
		//end fifth example

		// start sixth example 
		names1 = new List<string> () { "Sophie", "Nenette", "Clara" };
		foreach (string name in names1) {
			if (name == "Nenette") {
				print ("Nenette");
				break;
			}
			print ("OK");
		}


		//End sixth example
	}

	//Start 7th example
	void checkData ()
	{
		GameObject sphere1 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphereList.Add (sphere1);
		GameObject sphere2 = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphereList.Add (sphere2);
		foreach (GameObject sphere in sphereList) {	
			print (sphere);
		}
	}
	//end 7th example

	// start 8th example
	public void checkData2 ()
	{
		GameObject capsule1 = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		capsuleList.Add (capsule1);
		GameObject capsule2 = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		capsuleList.Add (capsule2);
		GameObject capsule3 = GameObject.CreatePrimitive (PrimitiveType.Capsule);
		capsuleList.Add (capsule3);
		foreach (GameObject capsule in capsuleList) {
			print (capsule);
		}
	}
	//end 8th example

	//start 9th example
	public void checkData3 ()
	{
		GameObject cube1 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubeList.Add (cube1);
		GameObject cube2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubeList.Add (cube2);
		GameObject cube3 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubeList.Add (cube3);
		GameObject cube4 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cubeList.Add (cube4);
		foreach (GameObject cube in cubeList) {
			print (cube);
		}
	}
	//end 9th example

	//start 10th example
	public void checkData4 ()
	{	GameObject cyl1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		cylList.Add (cyl1);
		foreach (GameObject cylinder in cylList) {
			print (cylinder);	
		}	
	}
	//end 10th example
}
