using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carController : MonoBehaviour {

	public bool moveFast = false;
	public static float speed = 0;

	public Text limit_reached;

	public float limit = 0;

	bool end = false; 

	void Start(){

		limit = 0.9f;
	}

	void Update(){
		if (!end) {
			if (moveFast) {
				if (speed < 1)
					speed += 0.005f;
				transform.Translate (0, speed, 0);
			}
		}
		if (!moveFast) {
			if (speed > 0) speed -= 0.01f;
			if (speed < 0)
				speed = 0;
			transform.Translate (0, speed, 0);
		}

		if (speed > limit) {
			limit_reached.gameObject.SetActive (true);
			end = true;
		}
	}

	public void speedUp(){
		moveFast = true;
	}

	public void normalSpeed(){
		moveFast = false;
	}
}
