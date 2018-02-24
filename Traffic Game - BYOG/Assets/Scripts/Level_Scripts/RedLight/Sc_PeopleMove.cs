using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_PeopleMove : MonoBehaviour {

	bool move = Sc_OnTriggerPeople.move;

	float speed = 0f;

	public GameObject died;

	void Start(){
		speed = Random.Range (0.05f, 0.2f);
	}

	// Update is called once per frame
	void Update () {

		move = Sc_OnTriggerPeople.move;

		if (move)
			transform.Translate (new Vector3(speed,0,0));

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Car")
			died.SetActive (true);
	}

}
