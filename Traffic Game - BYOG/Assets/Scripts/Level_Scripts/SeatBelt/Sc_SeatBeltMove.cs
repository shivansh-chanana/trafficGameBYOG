using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_SeatBeltMove : MonoBehaviour {

	float timeBarFillAmount = Sc_TimerBar.fillAmount;

	bool win = false;

	public Transform originObject;
	public Transform targetObject;

	public GameObject superman;

	void Start(){
		superman.SetActive (false);
	} 

	void Update () {
		timeBarFillAmount = Sc_TimerBar.fillAmount;

		transform.position = Vector2.MoveTowards (new Vector2(transform.position.x,transform.position.y), new Vector2(originObject.transform.position.x,originObject.transform.position.y), 0.02f);
	
		if (timeBarFillAmount <= 0 && !win) {
			Sc_TimerBar.fillAmount = 10;
			Sc_chooseButton.ChangeScreen (); 
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		winShow ();
	}
		
	public void MoveTowardsTarget(){
		transform.position = Vector2.MoveTowards (new Vector2(transform.position.x,transform.position.y), new Vector2(targetObject.transform.position.x,targetObject.transform.position.y), 0.6f);
	}

	void winShow(){
		win = true;
		superman.SetActive (true);
		Invoke ("Win", 1f);
	}

	void Win(){
		Sc_TimerBar.fillAmount = 10;
		Sc_chooseButton.Win ();
	}

}
