using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope_and_Access_Modifiers : MonoBehaviour {

	//********* See AnotherClass script as well *********

	private AnotherClass myOtherClass;

	//Start first example
	//declares public int hamburgers equal to 5. Can be accessed outside of this class
	public int hamburgers = 5;

	//start second example

	//declares public integer hotDogs. Can be accessed from outside the class
	public int hotDogs = 2;

	//End second example


	//Start third example

	//declares private integer plates. Scope is limited to this class
	private int plates;

	//End third example


	//declares private integer napkins
	private int napkins;



	void Start()
	{
		myOtherClass = new AnotherClass ();
		myOtherClass.Menu (hamburgers, myOtherClass.hotDogs);
	}


	//creates public function Menu which takes integer parameters h and d
	public void Menu(int h, int d)
	{
		//Start fourth example

		//declares an integer variable for inventory. Local to Menu function
		int menuInventory;
		//Adds items and assigns to variable
		menuInventory = h + d;

		//End fourth example

	//Prints total inventory
	print ("Total inventory items: " + menuInventory);
	}
	//Start Fifth Example
	//creates private function Tableware which takes int parameters p and n. Function is local to this class
	private void Tableware(int p, int n)
	{
		//End fifth example

		//Start sixth example
		//declares an integer variable for inventory. Local to Tableware function
		int totalTableware;
		//Adds items and assigns to variable
		totalTableware = p + n;

		//End sixth example

		//Prints total inventory
		print ("Total tableware items: " + totalTableware);
	}



}