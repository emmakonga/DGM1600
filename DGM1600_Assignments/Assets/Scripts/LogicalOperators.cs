using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour 
{
	public string string1;
	public string string2;
	public string ab;
	public string ac;
	public string bc;

	// Use this for initialization
	public void OneButtonClick ()
	{
		if (string1 == "Thing1" && string2 == "Thing2") {
			print ("These things are quite tame.");
		}
		if (string1 == "Thing1" || string2 == "Thing2") {
			print ("It's fun to have fun if you know what to do.");
		}
		if (string1 != "Thing1" && string2 != "Thing2") {
			print ("Oh! What a shame, what a shame, what a shame.");	
		}
		if (ab == "Banana" || ac == "Cow" || bc == "Chair") {
			// some general actiions
		}

		if (ab == "Box") {
			//additional conditional actions for ab
		} else if (ac == "Mouse") {
			//additional conditional actions for ac
		} else if (bc == "Dog") {
			//additional conditional actions for bc

			print ("What so many actions.");

		}

		if (string1 == "Car" && string2 == "Bike") {
			print ("These things are on the road.");
		}
		if (string1 == "Basketball" && string2 == "Tenisball") {
			print ("These things are in sport field.");
		}
		if (string1 == "Chalk" && string2 == "Book") {
			print ("These things are in school.");
		}
	}


	void Update () {
		
	}
}
