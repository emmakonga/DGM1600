using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListHomework : MonoBehaviour {

	public List<string> names;
	public List<string> musicPlayList;
	public List<string> myStringList;
	public List<string> animals;
	public List<string> newListString;
	public List<string> animals2;
	public List<string> animals3;
	public List<string> sportGamesList;
	public List<string> babies;
	public List<string> animals4;
	public List<string> babyName;
	// Use this for initialization
	void Start ()
	{


		//Start first example
		musicPlayList.Add ("Back in black");
		musicPlayList.Add ("Jaded");
		musicPlayList.Add ("Thunderstruck");

		print ("Current PlayList:");
		for (int j = 0; j < musicPlayList.Count; j++) {
			print (musicPlayList [j]);
		}
		print ("Removing 'Jaded'...");
		print ("Updated PlayList:");
		musicPlayList.Remove (musicPlayList [1]);
		for (int u = 0; u < musicPlayList.Count; u++) {
			print (musicPlayList [u]);
		}
		//End first example

		//Start second example
		names.Add ("Steve");
		names.Add ("Samy");
		for (int i = 0; i < names.Count; i++) {
			print (names [i]);
		}
		//End second example

		//Start third example
		myStringList.Add ("Bill");
		myStringList.Add ("Tom");
		myStringList.Remove ("John");

		print ("Current StringList:");
		for (int t = 0; t < myStringList.Count; t++) {
			print (myStringList [t]);
		}
		print ("Removing 'John'...");
		print ("Updated stringList:");
		myStringList.Remove (myStringList [1]);
		for (int k = 0; k < myStringList.Count; k++) {
			print (myStringList [k]);
		}
		//End third example

		//Start fourth example
		animals.Add ("Cow");
		animals.Add ("Deer");
		for (int a = 0; a < animals.Count; a++) {
			print (animals [a]);
		}
		//End fourth example

		//Start fifth example
		newListString.Add ("Lion");
		newListString.Add ("Tiger");
		for (int s = 0; s < newListString.Count; s++) {
			print ("Total Animals" + newListString.Count);
		}
		//End fifth example


		//Start sixth example
		animals2.Add ("Rat");
		animals2.Add ("Snake");
		animals2.Remove ("Camel");

		print ("Current animals2:");
		for (int b = 0; b < animals2.Count; b++) {
			print (animals2 [b]);
		}

		print ("Removing 'Camel'...");
		print ("Updated animals2:");
		animals2.Remove (animals2 [1]);
		for (int c = 0; c < animals2.Count; c++) {
			print (animals2 [c]);
		}
		//End sixth example

		//Start seventh example
		animals3.Add ("Dog");
		animals3.Add ("Cat");
		animals3.Add ("Fish");
		animals3.Add ("Bird");
		print ("Total Animals: " + animals3.Count);
		print ("First Animal: " + animals3 [0]);
		print ("Last Animal: " + animals3 [animals3.Count - 1]);
		animals3.Remove ("Bird");
		print ("Total Animals: " + animals3.Count);
		print ("First Animal: " + animals3 [0]);
		print ("Last Animal: " + animals3 [animals3.Count - 1]);








		//End seventh example

		//Start eigth example
		sportGamesList.Add ("Soccer");
		sportGamesList.Add ("Football");
		for (int g = 0; g < sportGamesList.Count; g++) {

			print (sportGamesList [g]);


		}
		//End eigth example

		//Start nineth example
		animals4.Add ("Monkey");
		animals4.Add ("Dolphin");
		animals4.Add ("Whale");
		animals4.Add ("Moose");
		print ("Current animals: ");
		for (int p = 0; p < animals4.Count; p++) 
		{
			print (animals4 [p]);
		}
		print ("Removing Dolphin from list...");
		animals4.Remove ("Dolphin");
		for (int p = 0; p < animals4.Count; p++) 
		{
			print (animals4 [p]);
		}



		//End nineth example


		//Start tenth example
		babies.Add ("Boy");
		babyName.Add ("James");
		babies.Add ("Girl");
		babyName.Add ("Sarah");
		babies.Add ("Boy");
		babyName.Add ("David");
		babies.Add ("Boy");
		babyName.Add ("Steven");
		print ("Total babies: " + babies.Count);
		for (int q = 0; q < babies.Count; q++) {
			print ("Gender: " + babies [q]);

		}
		//End tenth example

	}
}

