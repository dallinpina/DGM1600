using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontBeMadAtMe : MonoBehaviour {

	public Text textbox;

	public enum States {start, table, window, door0, door1, locked, stairs, pirate, water, fight, run};
	public States mystate;

	private bool key = false;

	// Use this for initialization
	void Start () {
		mystate = States.start;

	}
	
	// Update is called once per frame
	void Update () {
		if (mystate == States.start) {
			State_start ();
		} else if (mystate == States.table) {
			State_table ();
		} else if (mystate == States.window) {
			State_window ();
		} else if (mystate == States.door0) {
			State_door0 ();
		} else if (mystate == States.door1) {
			State_door1 ();
		} else if (mystate == States.locked) {
			State_locked ();
		} else if (mystate == States.stairs) {
			State_stairs ();
		} else if (mystate == States.pirate) {
			State_pirate ();
		} else if (mystate == States.water) {
			State_water ();
		} else if (mystate == States.fight) {
			State_fight ();
		} else if (mystate == States.run) {
			State_run ();
		}
}


	//functions for all of my states
	void State_start () {
		textbox.text = "You awake in a small room.  It appears to be on a ship, outside you can hear the voices of pirates." +
			"\n in the room there is a Table" +
			"\n there is a window" +
			"\nthere is a door." +
			"\n\n press T to go to table. press W to go to window.  press D to go to door";

		if (Input.GetKeyDown (KeyCode.T)) {
			mystate = States.table;
		} 
		else if (Input.GetKeyDown (KeyCode.D)) {
			mystate = States.door0;
		}
		else if (Input.GetKeyDown (KeyCode.W)) {
			mystate = States.window;
		}

	}

	void State_table () {
		textbox.text = "On the table there is a map and a set of keys." +
			"\n looking at the map you realize that this is the last stop before sailing to Europe where you will be sold as a slave" +
			"\n The Keys look like they might fit the door, but you aren't sure" +
			"\n\n press K to take the Keys" +
			"\n\n press S to go back to the start";

		if (Input.GetKeyDown (KeyCode.S)) {
			mystate = States.start;
		}
		if (Input.GetKeyDown (KeyCode.K)) {
			key = true;
		}
	}

	void State_window () {
		textbox.text = "You look out the window and see you are currently docked at an island" +
		"\n There are a lot of pirates outside, escaping might be tricky" +
		"\n Just across the bay you see the jungle, a perfect place to hide and escape to freedom...if you can first escape" +
		"\n\n press S to go back to the start";

		if (Input.GetKeyDown (KeyCode.S)) {
			mystate = States.start;
		}
	}

	void State_door0 () {

		if (key == true) {
			mystate = States.door1;
		}

		textbox.text = "The door is locked, wouldn't it be convinient if there were an extra set of keys lying around?" +
			"\n\n press S to go back to start";

		if (Input.GetKeyDown (KeyCode.S)) {
			mystate = States.start;
		}
	}

	void State_door1 (){
		textbox.text = "You use the keys you found on the Table to Unlock the door.  That was very convinient.." +
			"\n\nOutside the door you see a stairwell with stairs leading to the outside, where you can hear a mulitiude of pirates yelling and fighting." +
			"\nit sounds like they are getting ready to go you better hurry!" +
			"\n\n You also see a pirate gurading your door, right now he is sleeping." +
			"\n\npress U to go Up the stairs" +
			"\npress P to strangle the pirate while he is sleeping" +
			"\npress S to go back into your room";

		if (Input.GetKeyDown (KeyCode.S)) {
			mystate = States.locked;
		}
		if (Input.GetKeyDown (KeyCode.U)) {
			mystate = States.stairs;
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			mystate = States.pirate;
		}
	}
		
	void State_locked (){
		textbox.text = "when going back into your room the door squeaks and wakes up the guard, he relocks the door and takes the keys locking you in there forever" +
		"\nYou did not escape" +
		"\n\npress R to Restart";

		if (Input.GetKeyDown (KeyCode.R)) {
				mystate = States.start;
			}
	}

	void State_stairs () {
		textbox.text = "You quitley creep up the stairs, careful not to wake the guard.  At the top you peek out and see a crew of pirates you will have to get past if you want to escape." +
			"\n\nyou have decide you have a couple of options:" +
			"\npress S to go back to your room" +
			"\npress W to make a run for the water and jump into the bay" +
			"\npress F to fight the pirates" +
			"\npress R to run past the pirates and make a run for the land";

		if (Input.GetKeyDown (KeyCode.S)) {
			mystate = States.locked;
		}
		if (Input.GetKeyDown (KeyCode.W)) {
			mystate = States.water;
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			mystate = States.fight;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.run;
		}
	}

	void State_pirate () {
		textbox.text = "You attempt to strangle the guard in his sleep but when he awakes he overpowers you and kills you." +
		"\n\nyou died" +
		"\n\npress R to Restart";
		
		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.start;
		}
	}

	void State_water (){
		textbox.text = "You run to the edge of the boat and jump into the water.  The priates are waiting for you to surface, but you quickly swim away under the surface.  " +
		"\nYou are presumed dead and you quickly swim to land and make it to freedom!" +
		"\n\nCongradulations! You Escaped!" +
		"\n\npress R to play again!";

		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.start;
		}
	}

	void State_fight () {
		textbox.text = "You are confident in your abilites, and you go and fight the pirates head on." +
		"\nunfortunately there are way too many of them and you are over powered and killed" +
		"\n\nyou died" +
		"\n\npress R to restart";

		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.start;
		}
	}

	void State_run () {
		textbox.text = "You quickly run past the pirates, catching them all by suprise.  You make it to land where the local sherif hears the shouting and decides to investigate" +
		"\nThe sherif arrests you and puts you in jail for the rest of you life :(" +
		"\n\nyou did escape, and then got captured again." +
		"\n\npress R to restart";

		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.start;
		}
	}
}


