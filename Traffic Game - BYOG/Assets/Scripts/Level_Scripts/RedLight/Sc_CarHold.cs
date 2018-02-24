using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarHold : MonoBehaviour {

	bool stopMoving = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (stopMoving)
			transform.Translate (0, 0, 0);
		else
			transform.Translate (0, 0.1f, 0);
	}

	public void OnMouseDown(){
		stopMoving = true;
	}

	public void OnMouseUp(){
		stopMoving = false;		
	}
}
