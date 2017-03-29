using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loops : MonoBehaviour
{


	int numEnemies = 3;
	public List<string> cars;
	public int g;
	int numFriends = 5;
	int myNumber = 0;
	int enemiesDistance = 0;

	// Use this for initialization
	void Start ()
	{
		//start first example
		for (int i = 0; i < numEnemies; i++) {
			print ("creating enemy number:" + i);
		}	
		// end first example 

		//start second example
		cars.Add("Porsche");
		cars.Add ("Ferrari");
		cars.Add ("Mercedes");
		for (int i = 0; i < cars.Count; i++) {
			print (cars [i]);
		}

		RotateWheelRight ();
		Hello ();
		LoopTest ();
		LoopTest2 ();
		LoopTest3 ();
		EnemiesSearch1 ();
		EnemiesSearch2 ();
		EnemiesSearch3 ();
		number ();
	}

	//end second example


	//start third example

	void RotateWheelRight ()
	{
		for (int i = 0; i < 50; i++) {
			print ("Rotating " + i);
			if (i >= 50) 
			{
				print ("Stop!");
			}
		}
	
	}

	//end third example

	//start fourth example
	void Hello ()
	{
		for (int i = 0; i < 3; i++) {
			print ("Hello");
		}
	}

	//end fourth example


	//start fifth example

	void LoopTest ()
	{
		for (int i = 0; i < 10; i++) {

			print ("Loop");
		}
	}
	//end fifth example


	//start sixth example
	void LoopTest2 ()
	{
		
		for (int i = 10; i > 0; i--) {
			

			print ("Loop");
		}
	}
	//end sixth example


	//start sixth example

	void LoopTest3 ()
	{
		for (int i = 9; i > -1; i--) {
			print ("Loop");
		}
	}
	//end sixth example


	//start seventh example

	void EnemiesSearch1 ()
	{
		for (int i = 0; i < numEnemies; i++) {
			enemiesDistance = Random.Range (1, 10);
			if (enemiesDistance >= 8) {
				print ("Enemy is far from here.");
			}
		}
	}


	//end seventh example

	//start eigth example

	void EnemiesSearch2 ()
	{
		for (int i = 0; i < numEnemies; i++) {
			enemiesDistance = Random.Range (1, 10);
			if (enemiesDistance >= 4 && enemiesDistance <= 7) {
				print ("Enemy is getting closer");
			}	
		}
	}

	//end eigth example

	//start nineth example

	void EnemiesSearch3 ()
	{
		for (int i = 0; i < numEnemies; i++) {
			enemiesDistance = Random.Range (1, 10);
			if (enemiesDistance < 4) {
				print ("Enemy is very close and has terrible smell");
			}
			//else if(enemiesDistance > 4){print(enemey is farther away)}
		}
	}
	//end nineth example


	//start tenth example

	void number ()
	{
		for (int i = 0; i < 10; i++) {
			print ("Count: " + i);

		}
	}

}
//end tenth example
		
	

