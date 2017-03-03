using UnityEngine;
using System.Collections;

public class Switch_While_Script : MonoBehaviour {

	// First Switch example{
	public char grade = 'A';
	public char op = '+';
	public int score = 40;
	public int cupSize = 1;

	void Start ()
	{
		/*School's grade*/


		switch(grade){


		case 'A':
			print ("Excellent");
			break;
		case 'B':
			print ("Good job");
			break;

		case 'C':
			print ("Good but needs improvement");
			break;
		case 'D':
			print("Acceptable");
			break;

		case 'F':
			print("Inacceptable");
			break;

		default:
			print("Invalid grade");
			break;
		}
		print("Your grade is: " + grade);

		// Second Switch example

		switch (op)
		{
		case '+':
			print ("You chose to add");
			break;

		case '-':
			print ("You chose to substract");
			break;

		case '*':
			print ("You chose to multiply");
			break;

		case '/':
			print ("You chose to divide");
			break;

		default:
			print ("That is an invalide operator");
			break;

		}

		// Third Switch example

		switch (score)
		{
		case 100:
			print("A+");
			break;

		case 30:
			print("study more");
			break;

		case 65:
			print("C");
			break;

		case 80:
			print("B");
			break;

		case 95:
			print("A");
			break;

		default:
			print ("Please enter a valid score");
			break;
		}

		// Fourth Switch example

		switch (cupSize)
		{
		case 1:
			print("Small: + = 50 Scents");
			break;

		case 2:
			print("Medium = $1,00");
			break;

		case 3:
			print("Large = $1,50");
			break;

		default:
			print ("Extra large, no in this store");
			break;
		}
		// Fifth Switch example


	}
	// Update is called once per frame
	void Update () {

	}
}	
	

	