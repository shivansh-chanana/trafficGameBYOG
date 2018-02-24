using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_OnTriggerPeople : MonoBehaviour {

	public static bool move = false;

	void OnTriggerEnter2D(Collider2D col){
		move = true;	
	}
}
