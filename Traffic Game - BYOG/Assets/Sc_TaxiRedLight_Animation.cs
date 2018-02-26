using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_TaxiRedLight_Animation : MonoBehaviour {

	SpriteRenderer sR;

	public Sprite greenLight;

	void Start(){
		sR = GetComponent<SpriteRenderer> ();
	}

	void Update () {
		if (Sc_OnTriggerPeople.move == true)
			Invoke ("changeToGreen",2.5f);
	}

	void changeToGreen(){
		sR.sprite = greenLight;	
	}
}
