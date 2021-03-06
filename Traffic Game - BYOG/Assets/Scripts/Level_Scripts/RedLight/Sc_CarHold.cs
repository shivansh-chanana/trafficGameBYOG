﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EazyTools.SoundManager;

public class Sc_CarHold : MonoBehaviour {

	bool stopMoving = false;

	public static bool finish = false;

	public AudioClip car_brakes;

	// Use this for initialization
	void Awake () {
		finish = false;
		stopMoving = false;
		Sc_TimerBar.fillAmount = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (stopMoving && finish == false)
			transform.Translate (0, 0, 0);
		else if(Sc_PeopleMove.colDead == false)
			transform.Translate (0, 0.1f , 0);

		if (Sc_TimerBar.fillAmount <= 0 && finish == false)
			Lose ();
	}

	public void OnMouseDown(){
		SoundManager.PlaySound (car_brakes);
		stopMoving = true;
	}

	public void OnMouseUp(){
		stopMoving = false;		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Finish") {
			finish = true;
			Invoke ("Win", 1.5f);
		}
	}

	void Win(){
		Sc_chooseButton.Win ();
	}

	void Lose(){
		Sc_chooseButton.ChangeScreen ();
	}
}
