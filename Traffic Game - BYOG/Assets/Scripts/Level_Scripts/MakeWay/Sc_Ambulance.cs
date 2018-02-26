using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_Ambulance : MonoBehaviour {

	public bool move;

	float moveSpeed = 1f;

	public static bool ambulanceReached = false;

	float timeBarFillAmount;

	// Use this for initialization
	void Start () {
		ambulanceReached = false;
		move = true;
	}
	
	// Update is called once per frame
	void Update () {

		timeBarFillAmount = Sc_TimerBar.fillAmount;

		if (move)
			transform.Translate (0, Mathf.Lerp(0,moveSpeed,0.05f), 0);
		else
			transform.Translate (0, 0, 0);
		
		if (timeBarFillAmount <= 0 && ambulanceReached == false) {
			Sc_chooseButton.ChangeScreen (); 
		}

		if (timeBarFillAmount <= 0 && ambulanceReached == true) {
			Sc_chooseButton.Win (); 
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		

		if (col.gameObject.tag == "Finish")
			ambulanceReached = true;
		else move = false;
	}

	void OnTriggerExit2D(Collider2D col){
		 move = true;
	}

}
