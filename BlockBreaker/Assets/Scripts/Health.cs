using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
	private int count = 0;
	public int health;
	private Levelmanager levelManager;

	void Start () {
		levelManager = FindObjectOfType<LevelManager> ();
	}

	//adding these square brackets turns it into an array
	public Sprite[] picture;

	void OnCollisionEnter2D (Collision2D myCollider) {

		//Take away health
		health --;
	
		count++;

		//if health is < 0 destroy brick
		if (health <= 0){
			Destroy (this.gameObject);
			levelManager.UpdateBrickCount ();
		} 

		//sets sprite to which number array picutre
		GetComponent<SpriteRenderer> ().sprite = picture [count];
	}

}
