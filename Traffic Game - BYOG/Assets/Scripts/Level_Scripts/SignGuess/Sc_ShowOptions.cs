using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Sc_ShowOptions : MonoBehaviour {

	//For start Animation
	public PlayableDirector pd;

	//Next gameobject
	public GameObject optionType;

	//Timeperiod for an event
	int timePeriod = 5;

	//so that endAnimation doesnt play again
	bool end = false;

	void Update() {
		
		//Create Options after Specific Timeperiod;
		//if(Input.GetKeyDown(KeyCode.A)) showOptions();  //To check if showOptions is working or not
		if(end != true)Invoke ("showOptions",timePeriod);
	}
		
	//To end this GameObject
	void showOptions (){
		pd.Play ();
		Invoke ("destroyAfterAnim", 0.5f);
		Sc_TimerBar.time = 10;
		end = true;
	}

	//Destroy after animation and plays the next object
	void destroyAfterAnim(){
		optionType.SetActive (true);
		DestroyObject (this);
	}

}
