using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	int health = 3;
	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		//health -= 1; is the same as health = health -1; 
		health = health - 1; 
		if (health == 0){
			Break(	);
		}

	}
	void Break(){
		gameObject.SetActive (false);		
	}
}
