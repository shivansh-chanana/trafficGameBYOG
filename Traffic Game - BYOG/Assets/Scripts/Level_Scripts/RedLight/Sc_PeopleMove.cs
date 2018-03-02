using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PeopleMove : MonoBehaviour {

	bool move = Sc_OnTriggerPeople.move;

	public float speed = 0.01f;

	public static bool colDead = false;

	Animator anim;

	// Update is called once per frame

	void Awake(){	
		colDead = false;

		anim = GetComponent<Animator> ();
	}

	void Update () {

		move = Sc_OnTriggerPeople.move;

		if (colDead == false) {
			if (move)
				transform.Translate (new Vector3 (speed * Time.deltaTime * 60, 0, 0));
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Car") {
			if (!colDead) {
				Invoke ("Dead", 2f);
				anim.SetBool ("dead",true);
				colDead = true;
			}
		}
	}

	void Dead(){
		Sc_chooseButton.ChangeScreen ();
	}
}
