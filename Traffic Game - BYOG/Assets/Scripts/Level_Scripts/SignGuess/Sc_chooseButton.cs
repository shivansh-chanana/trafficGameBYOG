using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;

public class Sc_chooseButton : MonoBehaviour {

	//Specific button no
	public int buttonNo = 0;

	//Correct answer choosen in OptionController Script
	int CorrectAnswer = -1;

	//Right and Wrong Text
	public Text rightAnswer;
	public Text wrongAnswer;

	public GameObject crashedImg;

	public PlayableDirector pd;
	//For Checking Answer
	public void checkAnswer(){
		CorrectAnswer = Sc_optionsController.rand;

		if (CorrectAnswer == buttonNo) {
			wrongAnswer.gameObject.SetActive (false);
			rightAnswer.gameObject.SetActive (true);
		} else {
			Out();
		}
	}

	public void Out(){
		Invoke ("CrashedImgShow", 1.3f);
		pd.Play ();
	}

	void CrashedImgShow(){
		crashedImg.SetActive (true);
	}
}
