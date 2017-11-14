using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Lasers : MonoBehaviour {

	public float lifetime;

	public float speed;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		lifetime -= Time.deltaTime;
		if (lifetime <= 0) {

		}

		transform.Translate (Vector3.up * speed * Time.deltaTime);
	}
}

