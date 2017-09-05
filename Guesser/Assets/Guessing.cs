using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guessing : MonoBehaviour {
	
	int max = 100;
	int min = 1;
	int guess = 50;

	// Use this for initialization
	void Start () {

		max = max + 1;

		print ("Welcome to Number Guesser");
		print ("Pick a number in your head");

		print ("The highest number you can pick is " + max);
		print ("the lowest number you can pick is " + min);

		print ("is the number higher of lower than " + guess);
		print ("Up arrow for higher, Down for lower, and Enter for equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			guess = (max + min) / 2;
			print ("is the number higher of lower than " + guess);
			}
		if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (guess + min) / 2;
			print ("is the number higher of lower than " + guess);
		}
		if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is " + guess);
		}
	}
}