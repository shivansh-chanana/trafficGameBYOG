using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_redLightTimer : MonoBehaviour {

	public Image redLight;

	public int timer = 5;

	public static bool redLightOn = false;

	public GameObject car;
	public Transform zebra;

	void Start () {
		Invoke ("RedLight", timer);
	}

	void RedLight(){
		redLight.color = Color.red;
		redLightOn = true;
		Instantiate (car,new Vector3(zebra.position.x + 2, 6.6f,0),Quaternion.identity);
	}
}
