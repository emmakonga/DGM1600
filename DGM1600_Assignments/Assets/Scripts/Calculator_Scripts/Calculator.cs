using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Calculator:MonoBehaviour
{
	public InputField Input;
	public Button button;
	public List<Text> FaillingButtons;
	public Text gameOver;

	int firstNum;
	int secondNum;

	public void Awake ()
	{
		print ("Calculator just turned on");
	}

	void Start ()
	{
		foreach (Text item in FaillingButtons) 
		{
			item.text = Random.Range (1, 10).ToString ();
		}
		gameOver.text = "";
	}

	public void ButtonPressed ()
	{
		switch (button.name) 
		{
		case "+":
			Input.text += " + ";
			break;
		case "-":
			Input.text += " - ";
			break;
		case "/":
			Input.text += " / ";
			break;
		case "*":
			Input.text += " * ";
			break;
		default:
			Input.text += button.name;
			break;
		}
	}

	public void getNumber()
	{
		string[] numbers = Input.text.Split ();
		firstNum = int.Parse (numbers [0]);
		string mathOperator = numbers [1];
		secondNum = int.Parse (numbers [2]);

		switch (mathOperator) 
		{
		case "+":
			Input.text = (firstNum + secondNum).ToString ();
			break;
		case "-":
			Input.text = (firstNum - secondNum).ToString ();
			break;
		case "/":
			Input.text = (firstNum / secondNum).ToString ();
			break;
		case "*":
			Input.text = (firstNum * secondNum).ToString ();
			break;
		default:
			break;
		}
	}

	public void clear()
	{
		Input.text = "";
	}

	public void FaillingButtonsControler()
	{
		foreach (Text item in FaillingButtons) 
		{
			if (Input.text == item.text)
			{
				item.gameObject.SetActive (false);
			}
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Plane")
		{
			gameOver.text = "Game Over";
		}
	}
}