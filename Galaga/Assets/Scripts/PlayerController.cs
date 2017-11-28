using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject projectile;
	public Transform shotPos;
	public float shotForce;




	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePosition.z = 0;


		if(Input.GetButtonUp("Fire1"))

		{
			GameObject shot = Instantiate (projectile, shotPos.position, shotPos.rotation) as GameObject;
			shot.GetComponent<Rigidbody2D> ().AddForce (shotPos.up * shotForce);
			//shot.AddForce (shotPos.forward * shotForce);
		



		}
	}
}
	
