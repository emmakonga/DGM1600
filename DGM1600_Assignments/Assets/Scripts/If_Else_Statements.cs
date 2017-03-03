using UnityEngine;
using System.Collections;

public class If_Else_Statements : MonoBehaviour {
	//Creates an integer variable for number of lives and sets it to 5
	int lives = 5;
	int bullets = 100;
	int apples = 40;
	int students = 20;
	int oranges = 0;
    int c = 5;
    public int a = 10;
	public int b = 20;
	public int trafficLight = 3;
    public int speedLimit = 60;
	int currentSpeed;

    // Use this for initialization
    void Start() {


        print("Oranges: " + oranges);
        print("Apples: " + apples);

        //Sets my lives to 5 at start of game 
        lives = 5;
        //and prints my lives
        print("You have " + lives + " lives left");
        //comparaison
        if (b > a) {
            print("B is greater than A");
        } else if (a > b) {
            print("A is greater than B");


        } else {
            print("A is equal to B");
        }

        //Something else
		if (a == 5)
		{
        
			print ("Do something");
		}
        
        else if (a == 4)
        {
        print("Do something else");
        }
		else if (a > 3)
        {
        print("Do other stuff"); 
		}

        //Traffic Light
		if (trafficLight == 1) {

            print ("Red");	
		} 
		else if(trafficLight == 2)
		{
			print ("Yellow");
		}
		else if(trafficLight == 3)
		{
			print("Green");	
		}

        //Speed Limit
        if (currentSpeed < 60) {
				print("You are driving slow");
			
			}
            
       

		else if (currentSpeed > 60) {
				print("You are driving too fast");
        }
        
        
		else if(currentSpeed == 60){ 
				print("You are safe");
        }
       

	
	}

	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKey (KeyCode.Space) && bullets > 0) 
		{
			bullets--;
		}

		print ("Bullets: " + bullets);

		if (bullets == 0) {
		
			print ("Out of bullets!");
		
		}

		if (Input.GetKey (KeyCode.Space) && bullets > 0) 
		{
			bullets--;
		}
        students = 20;
        if (students > 10) {
			print ("The class is too full");
		} 
		else {
			print ("The class can hold this number of students");
		}

		if (Input.GetKeyDown (KeyCode.C) && students > 0) {

			students--;
		} 



		//I check if I press the L Key
		if (Input.GetKeyDown (KeyCode.L)) 
		{	
			//I decrease lives by one
			lives = lives--;
			//I print the updated number of lives
			print ("You have " + lives + " lives left");
		}

		//Checks if lives reaches zero
		if (lives == 0) {
			//If lives does reach zero, I print Game Over
			print ("Game Over");
		} 
		//Checks if lives equals 5
		else if (lives == 5) 
		{	//if it does equal 5, I print that I have the maximum number of lives
			print ("You are at maximum lives!");
		} 
		//Checks if lives equals 1
		else if (lives == 1) 
		{
			//If it does equal 1, I print that I'm on the last life
			print("Last life! Don't Die!");
		}

	
		if (Input.GetKeyDown (KeyCode.O)&& oranges < 25) {
			oranges++;
			print ("Oranges: " + oranges);
		}
			



	}
}
