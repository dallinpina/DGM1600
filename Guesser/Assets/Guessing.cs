using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guessing : MonoBehaviour {
	
	public Text textbox;

	private int max = 100;
	private int min = 1;
	private int guess;

	public int counter;

	// Use this for initialization
	void Start () {

		guess = Random.Range (min, max);

		textbox.text = "Welcome to Number Guesser "
			+ "\nPick a number in your head"
			+ "\n\nThe highest number you can pick is " + max
			+ "\nThe lowest number you can pick is " + min
			+ "\n\nIs the number higher or lower than " + guess
			+ "\nUp arrow for higher, Down for lower, Enter for equal";
		

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
			counter--;
			print ("is the number higher or lower than " + guess);

			textbox.text = "is the number higher or lower than " + guess;
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			guess = (guess + min) / 2;
			counter--;
			print ("is the number higher or lower than " + guess);

			textbox.text = "is the number higher or lower than " + guess;
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("Your number is " + guess);
			print ("computer wins!");

			textbox.text = "Your number is " + guess
			+ "\nComputer Wins!";
		}
		if (counter == 0) {
			counter--;
			print ("You Win, I lose!");

			textbox.text = "You win, I lose!";
		}
		if (counter == -1) {
			if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.DownArrow)) {
				print ("You Win!");

				textbox.text = "You Win!";
			}
		}
		//when counter reaches zero then player wins
	}
}