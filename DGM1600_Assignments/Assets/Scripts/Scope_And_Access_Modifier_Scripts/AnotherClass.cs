using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour {

	//*******See Scope_and_Access_Modifiers script as well********


	//Start seventh example
	//declares public integer hamburgers. Can be accessed outside of this class
	public int hamburgers = 5;
	//End Seventh example

	//Start eighth example
	//declares public integer hotDogs. Can be access outside of this class
	public int hotDogs = 2;
	//End eighth example

	//declares private integer plates
	private int plates;
	////declares private integer napkins
	private int napkins;

	//Start ninth example
	//creates public function Menu which takes integer parameters h and d
	public void Menu(int h, int d)
	{
		//Start tenth example
		//declares an integer variable for inventory. Local to Menu function
		int menuInventory;
		//Adds items and assigns to variable
		menuInventory = h + d;
		//Prints total inventory
		print ("Total inventory items: " + menuInventory);
		//End tenth example
	}
	//End ninth example

	

}
