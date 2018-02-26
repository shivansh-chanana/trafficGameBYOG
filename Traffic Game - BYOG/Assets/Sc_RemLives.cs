using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sc_RemLives : MonoBehaviour {

	int remlives = 0;

	Text showLivesTxt;

	// Update is called once per frame
	void Start(){

		showLivesTxt = GetComponent<Text> ();
		remlives = Sc_GameOver.remLife;
	
		showLivesTxt.text = remlives.ToString();
	}
}
