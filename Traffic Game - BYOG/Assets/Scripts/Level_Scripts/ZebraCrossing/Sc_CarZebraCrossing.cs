using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarZebraCrossing : MonoBehaviour {

	/*
	#region v1

	bool redLightOn = false;

	bool stopMoving = false;

	float speed = -0.2f;

	bool hit = false;

	void Update () {
		redLightOn = Sc_redLightTimer.redLightOn;

		if(redLightOn  && !Sc_ZebraVerticalDrag.OnZebraCrossing){
			if (!stopMoving || !Sc_ZebraVerticalDrag.OnZebraCrossing)
				if(!hit)transform.Translate (0, speed, 0);
		}

		if (speed == 0)
			Debug.Log ("Speed = 0");
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "ZebraCrossing")
			stopMoving = true;
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "zebra")
			hit = true;
	}
}

#endregion

	*/

	bool move = false;

	void Start(){
		Invoke ("startMoving", 3f);
	}

	void Update(){

		if (move == true) {
			transform.Translate (new Vector2 (0, -0.2f));
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "zebra") {
			move = false;
		}
	}

	void startMoving(){
		move = true;
	}
}