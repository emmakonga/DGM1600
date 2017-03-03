using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Button1Script : MonoBehaviour {

	public List<string> animals;
	string animal = "Cat";

	// Use this for initialization
	void Start () {
		animals = new List<string>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddAnimal()
	{
		animals.Add (animal);
	}
}
