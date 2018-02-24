using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarZebraCrossing : MonoBehaviour {

	bool redLightOn = false;

	bool stopMoving = false;

	void Update () {
		redLightOn = Sc_redLightTimer.redLightOn;

		if(redLightOn){
			if (!stopMoving)
				transform.Translate (0, -0.2f, 0);
		}
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "ZebraCrossing")
			stopMoving = true;
	}
}
