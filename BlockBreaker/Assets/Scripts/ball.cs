using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {

	public GameObject paddle;

	//a bool is a true of falso variable
	private bool playing = false;

	//vector3 is just a group of 3 numbers, for us its xyz cordinates
	private Vector3 paddleToBallVector;

	//created a physics variable to control the speed
	private Rigidbody2D rigid;



	void Start () {

		//assigned this variable a position to the difference beween the distances
		paddleToBallVector = this.transform.position - paddle.transform.position;

		//tells the code the get this component so we can mess with it
		rigid = this.GetComponent<Rigidbody2D> ();
	}


	void Update () {
		
		//the ! means the bool is not true
		if (!playing) {

			//moves the ball to the offsent position
			this.transform.position = paddle.transform.position + paddleToBallVector;
		}

		//if push start button
		if (Input.GetMouseButtonDown(0)) {
			//ball goes flying
			rigid.velocity = new Vector2 (4,20);
			//playing = true
			playing = true;


		}

	}
}
