using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class Sc_chooseButton : MonoBehaviour {

	//Specific button no
	public int buttonNo = 0;

	//Correct answer choosen in OptionController Script
	int CorrectAnswer = -1;

	public GameObject crashedImg;

	public PlayableDirector pd;
	//For Checking Answer

	void Awake(){
		CorrectAnswer = -1;
	}

	public void checkAnswer(){
		CorrectAnswer = Sc_optionsController.rand;

		if (CorrectAnswer == buttonNo) {
			Win ();
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
		Invoke ("ChangeScreenNoStatic", 0.5f);
	}

	public static void Win(){
		Sc_TimerBar.time = 10;
		SceneManager.LoadScene ("Out");
	}

	public static void ChangeScreen(){
		Sc_GameOver.remLife--;
		Sc_TimerBar.time = 10;
		SceneManager.LoadScene ("Out");
	}

	public void ChangeScreenNoStatic(){
		Sc_GameOver.remLife--;
		Sc_TimerBar.time = 10;
		SceneManager.LoadScene ("Out");
	}

}
