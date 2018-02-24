using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Ambulance : MonoBehaviour {

	public bool move;

	float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
		move = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (move)
			transform.Translate (0, Mathf.Lerp(0,moveSpeed,0.05f), 0);
		else
			transform.Translate (0, 0, 0);
	}

	void OnTriggerEnter2D(Collider2D col){
		move = false;
	}

	void OnTriggerExit2D(Collider2D col){
		 move = true;
	}

}
