using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EazyTools.SoundManager;


public class Sc_GameOver : MonoBehaviour {

	public Sprite[] sprite_remLife;

	public SpriteRenderer sR;

	public Button retryButton;

	public static int remLife = 3;

	public static int tempRemLife = 3;

	public Animator policeMen_Animator;

	public AudioClip fx_OhNo;
	public AudioClip fx_Yeayi;

	// Use this for initialization
	void Awake () {
	}

	void Start(){
		sR = GetComponent<SpriteRenderer> ();

		//If got out
		if (tempRemLife != remLife) {
			SoundManager.PlaySound (fx_OhNo);
			policeMen_Animator.SetBool ("Out", true);
			Invoke ("OutMethod", 1f);
			tempRemLife = remLife;


			if (remLife == 3)
				sR.sprite = sprite_remLife [0];
			if (remLife == 2)
				sR.sprite = sprite_remLife [0];
			if (remLife == 1)
				sR.sprite = sprite_remLife [1];

		} else {
			SumScore.Add (1);
			SumScore.SaveHighScore ();
			SoundManager.PlaySound (fx_Yeayi);
			OutMethod ();
		}
			


		//policeman Gameover animation and randomScene Start
		if (remLife > 0)
			Invoke ("RandomScene",1.3f);
		else policeMen_Animator.SetBool ("GameOver",true);
	}

	// Update is called once per frame
	void Update () {

		//For Prototype
		if (Input.GetKeyDown (KeyCode.A))
			remLife -= 1;

		//GameOver Changes
		if (remLife <= 0) {
			remLife = 0;
			sR.sprite = sprite_remLife [3];
			policeMen_Animator.SetBool ("GameOver",true);
			retryButton.gameObject.SetActive (true);
		}
	}

	void LateUpdate(){
		//time Static problem solution
		Sc_TimerBar.time = 10;
	}

	void OutMethod(){

		if (remLife == 3)
			sR.sprite = sprite_remLife [0];
		if (remLife == 2)
			sR.sprite = sprite_remLife [1];
		if (remLife  == 1)
			sR.sprite = sprite_remLife [2];
		
	}

	void RandomScene(){
		Sc_RandomScene.RandomSceneSelection ();
	}
}
