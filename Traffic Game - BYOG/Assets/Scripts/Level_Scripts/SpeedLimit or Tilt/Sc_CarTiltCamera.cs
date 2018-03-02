using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CarTiltCamera : MonoBehaviour {

	public GameObject car;

	public static bool stopFollowing = false;

	public float movSmoothness = 0.05f;
	// Update is called once per frame

	void Awake(){
		stopFollowing = false;
	}

	void Update () {

		if(!stopFollowing)transform.position = new Vector3 (transform.position.x,car.transform.position.y + 1.8f,-10);
	}
}
