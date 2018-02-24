using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarDrag : MonoBehaviour {

	public Rigidbody2D rb;

	void OnMouseDrag(){
		Vector2 mousePos = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		Vector2 objPos = Camera.main.ScreenToWorldPoint (mousePos);

		rb.velocity = (objPos - rb.position) * 50;
		//transform.position = objPos;
	}
}
