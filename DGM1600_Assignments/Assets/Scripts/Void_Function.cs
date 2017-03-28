using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Void_Function : MonoBehaviour 

	{
	public int weapon = 0;
	public string weaponName;
	//public class ReturnFunction;
	public string deepThought;




	// start first example
	void Start (){
	}
	// Update is called once per frame
	void Update () 
	{
			if (Input.GetKey (KeyCode.Space)) {
	
				WeaponSearch ();
			}
	}

	void WeaponSearch(){


		weapon = Random.Range (1,10);
		switch(weapon)
		{
		case 1:
		print("I got a gun");
		break;

		case 2:
			print("I got a chain");
			break;

		case 3:
			print("I got a knife");
			break;
		case 4: 
			print("I got an hamer");
			break;
			//Default:
			//print("I didn't find any weapon!");
			//break;
	//end first example
	}
	}


	//start second example
	void DisplayMessage()
		{
			print ("You got the" + weaponName + "!");
		}
	//end second example

	//start third example

	}




//} 