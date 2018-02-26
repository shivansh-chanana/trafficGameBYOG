using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_TimerBar : MonoBehaviour {
	
	public static float time;
	float  tempTime = 0;

	public float changableTime = 0;

 	Image timerBar;

	public static float fillAmount;

	void Start(){

		time = changableTime;

		timerBar = GetComponent<Image> ();

		tempTime = time;
	}

	// Update is called once per frame
	void Update () {

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
