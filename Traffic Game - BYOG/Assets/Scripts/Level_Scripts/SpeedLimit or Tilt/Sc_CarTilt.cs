using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarTilt : MonoBehaviour {

	public float magnitude;

	// Update is called once per frame
	void Update () {
	
		transform.Translate(new Vector2((Input.acceleration.x) * magnitude ,0.1f));
	}
		
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Car")
			Invoke ("Lose", 0.5f);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Finish") {
			Sc_CarTiltCamera.stopFollowing = true;
			Invoke ("Win", 1f);
		}
	}

	void Win(){
		Sc_chooseButton.Win ();
	}

	void Lose(){
		Sc_chooseButton.ChangeScreen ();
	}
}
