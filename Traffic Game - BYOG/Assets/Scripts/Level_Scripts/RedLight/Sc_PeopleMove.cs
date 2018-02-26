using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PeopleMove : MonoBehaviour {

	bool move = Sc_OnTriggerPeople.move;

	public float speed = 0.01f;

	public GameObject died;

	public static bool colDead = false;

	// Update is called once per frame

	void Awake(){	
		colDead = false;
	}

	void Update () {

		move = Sc_OnTriggerPeople.move;

		if (colDead == false) {
			if (move)
				transform.Translate (new Vector3 (speed, 0, 0));
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Car") {
			if (!colDead) {
				Invoke ("Dead", 2f);
				colDead = true;
			}
		}
	}

	void Dead(){
		Sc_chooseButton.ChangeScreen ();
	}
}
