using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sc_GameOver : MonoBehaviour {

	public SpriteRenderer lifeColor;

	public Button retryButton;

	public static int remLife = 3;

	int tempRemLife = 3;

	// Use this for initialization
	void Start () {
		if (tempRemLife != remLife) {
			Invoke ("OutMethod", 1f);
			tempRemLife = remLife;
		}

		if (remLife > 0)
			Invoke ("RandomScene",2f);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.A))
			remLife -= 1;

		if (remLife <= 0) {
			remLife = 0;
			retryButton.gameObject.SetActive (true);
		}
	}

	void OutMethod(){

		if (remLife == 3)
			lifeColor.color = Color.green;
		if (remLife == 2)
			lifeColor.color = Color.yellow;
		if (remLife  == 1)
			lifeColor.color = Color.red;
	}

	void RandomScene(){
		Sc_RandomScene.RandomSceneSelection ();
	}
}
