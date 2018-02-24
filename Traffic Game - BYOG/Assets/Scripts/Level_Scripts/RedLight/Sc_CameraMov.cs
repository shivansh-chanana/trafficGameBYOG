using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_CameraMov : MonoBehaviour {

	public GameObject car;

	public float movSmoothness = 0.05f;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (transform.position.x, Mathf.Lerp (transform.position.y,car.transform.position.y + 2.5f,movSmoothness),-10);
	}
}
