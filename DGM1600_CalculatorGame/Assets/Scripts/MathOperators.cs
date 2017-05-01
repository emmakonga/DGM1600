using UnityEngine;
using System.Collections;

public class MathOperators : MonoBehaviour {
    public int a = 12;
    public int b = 2;
    public int c = 3;
	public float d = 5f;
    public  int myInt;
    // Use this for initialization
    void Start()
    {
        //creates an int variable equal to A minus B
        int subInt = a - b;
        //creates an int variable equal to A plus B
        myInt = a + b;
        //creates an int variable equal to A times B
        int multInt = a * b;
        //creates an int variable equal to A divided by B
        int divInt = a / b;
        //creates an int variable equal to A modulus B
        int modInt = a % b;
        //creates an int variable equal (a + b) * c 
        int anotherInt = (a + b) * c;
		//creates an int variable equal to (b * c) + a
		int mathInt = (b * c) + a;
		//creates a Floating point variable equal to mathInt + divInt * subInt / c
		float myFloat = mathInt + divInt * subInt / c;
		//creates a floating variable equal to(A times B * c) / d
		float myFloat2 = (a * b * c) / d;
		//creates a floating variable equal to myInt + subInt - d
		float myFloat3 = myInt + subInt - d;

		//print my values
		print(myInt);
        print(subInt);
        print(multInt);
        print(a * b);
		//This line performs multiplication inside the print statement
        print(multInt * subInt);
        print(divInt);
        print(modInt);
        print(anotherInt);
		print(mathInt);
		print(myFloat);
		print(myFloat2);
		print(myFloat3);
    }

}
