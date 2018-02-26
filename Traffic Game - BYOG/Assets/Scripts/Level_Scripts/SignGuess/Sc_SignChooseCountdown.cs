using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_SignChooseCountdown : MonoBehaviour {


	void Awake(){
		Sc_TimerBar.fillAmount = 10;
	}

	// Update is called once per frame
	void Update () {

		if (Sc_TimerBar.fillAmount <= 0){
			Sc_chooseButton.ChangeScreen ();
		}
	}
}
