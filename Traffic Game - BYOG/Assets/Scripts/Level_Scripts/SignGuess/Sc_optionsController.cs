using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sc_optionsController : MonoBehaviour {

	//To access Canvas //To enable it
	public Canvas canvas;

	//GameObject[] = SignBoard[] to show
	public GameObject[] signs;

	// Random sign No. //Sc_ChooseButton can also access it for choosing correct button
	public static int rand = 0;

	// Use this for initialization
	void Start () {
		//for selecting random sign
		rand = Random.Range (0, 4);

		//To activate choosen sign
		signs [rand].gameObject.SetActive (true);
		//to Enable Canvas which is currently dissabled
		canvas.gameObject.SetActive (true);	
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene("Level_SignGuess");
	}
}
