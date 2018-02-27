using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_redLightTimer : MonoBehaviour {



	public int timer = 5;

	public static bool redLightOn = false;

	public Transform zebra;

	SpriteRenderer greenLight;
	public Sprite redLight;

	void Awake () {
		redLightOn = false;
		Invoke ("RedLight", timer);
	}

	void Start(){
		greenLight = GetComponent<SpriteRenderer>();
	}

	void RedLight(){
		greenLight.sprite = redLight;
		redLightOn = true;
	}
}
