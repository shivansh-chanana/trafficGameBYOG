using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_ZebraVerticalDrag : MonoBehaviour {

	public Rigidbody2D rb;

	bool redLightOn = false;

	public static bool OnZebraCrossing = false;

	void Update(){
		redLightOn = Sc_redLightTimer.redLightOn;

		if (redLightOn) {
			transform.Translate (0.03f, 0, 0);	
		}
	}

	void OnMouseDrag(){
		Vector2 mousePos = new Vector2 (0, Input.mousePosition.y);
		Vector2 objPos = Camera.main.ScreenToWorldPoint (mousePos);

		//rb.velocity = (objPos - rb.position) * 50;
		transform.position = new Vector2(transform.position.x, objPos.y);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "ZebraCrossing")
			OnZebraCrossing = true;
	}

	void OnTriggerExit2D(Collider2D col){
			OnZebraCrossing = false;
	}
}

