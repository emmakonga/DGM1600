using UnityEngine;
using System.Collections;

public class Whie_L00ps : MonoBehaviour {

	int numberOfEnemies = 25;
	int dirtyDishes = 5;
	int hamburgers = 10;
	int hoursToDrive = 8;
	int ouncesOfWater = 48;
	int pounds = 200;
	float timer = 2700.0f;
	int numberOfFeet = 5280;
	int hotDogsEaten = 0;

	// Use this for initialization
	void Start () {

		//While number of enemies is greater than 0
		while (numberOfEnemies > 0)
		{
			//kill an enemy
			print ("I killed an enemy!");
			//decrease the number of enemies by one
			numberOfEnemies--;
		}

		//While the number of plates in dishwasher is greater than 0
		while (dirtyDishes > 0)
		{
			//wash a dish
			print ("I washed a dish!");
			//decrease the number of dirty dishes by one.
			dirtyDishes--;
		}


		    //while the number of humburger is greater than 1
		while (hamburgers > 1)
		{
			//eaten humburger
			print ("I ate a humburger!");
			//decrease the number of humburger until one humburger left
			hamburgers--;
		}


			//while ounces of water is greater than 0
		while (ouncesOfWater > 0)
		{
			//drank water
			print ("I drank 12 ounces of water...");
			//decrease ounces of water by twelve ounces
			ouncesOfWater -= 12;
		}

			//while my weight was > 180
		while (pounds > 180)
		{
			// I lost weight
			print ("I lost weight!");
			//decreasing pounds by 2 pounds/day
			pounds -= 2;
		}

			//while time is greater than 0,
		while (timer > 0)
		{
			//print clock is running
			print ("Clock running...");
			//decrease the timer by second

			timer--;
		}

			//while the number of foot is greater than 0
		while (numberOfFeet > 0)
		{
			//walk
			print ("I walked one foot...");
			//decrease the number of foot by one
			numberOfFeet--;
		}

		//while the number of hot dog is less than 22
		while (hotDogsEaten < 22)
		{
			//eaten hot dog
			print ("I ate one hot dog off my plate...");
			//increase the number of eaten hot dog by one
			hotDogsEaten++;

		}
		//Creates bool "shouldContinue" equal to false
		bool shouldContinue = false;

		   //Perform this code
		do
		{
			//print hello
			print ("Hello World");

		}
			//After I have printed once, only print hello if shouldContinue bool is true
		while(shouldContinue == true);



		//creates int variable "bullets" equal to zero
		int bullets = 0;

		//perform this code
		do
		{
			//print message
			print ("Click!");


		} 
		//After I have printed once, only print "click" if bullets greater than zero
		while(bullets > 0);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
