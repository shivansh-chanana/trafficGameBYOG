using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_TimerBar : MonoBehaviour {
	
	public static float time = 5;
	float  tempTime = 0;

 	Image timerBar;

	void Start(){

		timerBar = GetComponent<Image> ();

		tempTime = time;
	}

	// Update is called once per frame
	void Update () {

		if (time > 0)
			time -= Time.deltaTime;
		else
			time = 0;

		timerBarFill ();
	}

	void timerBarFill (){
		timerBar.fillAmount = time / tempTime;
	}
}
