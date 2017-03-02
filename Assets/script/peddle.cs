using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peddle : MonoBehaviour {

	Rigidbody2D rigidbody 
	float speed = 5

	void Start(){
		rigidBody = GetComponent<Rigidbody2D>();
	}
		
	void Update () {

		float x = Input.GetAxisRaw ("Horizontal");
		x = x * speed;
		rigidBody.velocity = new Vector2 (x,0);
	}
}
