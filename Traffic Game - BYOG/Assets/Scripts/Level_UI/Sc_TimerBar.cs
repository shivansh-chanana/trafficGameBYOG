using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_TimerBar : MonoBehaviour {
	
	public static float time = 10;
	float  tempTime = 10;

	public float changableTime = 10;

 	Image timerBar;

	public static float fillAmount = 5;

	void Awake(){

		time = changableTime;

		timerBar = GetComponent<Image> ();

		tempTime = time;
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Z))
			time = 0;

		if (time > 0)
			time -= Time.deltaTime;
		else
			time = 0;

		fillAmount = timerBar.fillAmount;

		timerBarFill ();
	}

	void timerBarFill (){
		timerBar.fillAmount = time / tempTime;
	}
}
