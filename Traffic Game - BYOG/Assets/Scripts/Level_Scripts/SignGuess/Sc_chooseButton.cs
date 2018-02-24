using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_chooseButton : MonoBehaviour {

	//Specific button no
	public int buttonNo = 0;

	//Correct answer choosen in OptionController Script
	int CorrectAnswer = -1;

	//Right and Wrong Text
	public Text rightAnswer;
	public Text wrongAnswer;

	//For Checking Answer
	public void checkAnswer(){
		CorrectAnswer = Sc_optionsController.rand;

		if (CorrectAnswer == buttonNo) {
			wrongAnswer.gameObject.SetActive (false);
			rightAnswer.gameObject.SetActive (true);
		} else {
			rightAnswer.gameObject.SetActive (false);
			wrongAnswer.gameObject.SetActive (true);
		}
	}
}
