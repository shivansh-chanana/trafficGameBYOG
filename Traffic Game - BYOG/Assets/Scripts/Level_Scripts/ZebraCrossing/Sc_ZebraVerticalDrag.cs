using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EazyTools.SoundManager;

public class Sc_ZebraVerticalDrag : MonoBehaviour {

	public Rigidbody2D rb;

	bool redLightOn = false;

	public static bool OnZebraCrossing = false;

	Animator zebra_anim;

	bool dead = false;

	public AudioClip fx_crash;

	public GameObject tut_ZebraDrag;

	void Start(){
		dead = false;
		zebra_anim = GetComponent<Animator>();
		zebra_anim.enabled = false;
	}

	void Update(){
		redLightOn = Sc_redLightTimer.redLightOn;

		if (redLightOn && !dead) {
			tut_ZebraDrag.SetActive (false);
			zebra_anim.enabled = true;
			zebra_anim.Play ("People_Walk_anim");
			transform.Translate (0.03f * Time.deltaTime * 60, 0, 0);	
		}
	}

	void OnMouseDrag(){
		if (!redLightOn) {
			Vector2 mousePos = new Vector2 (0, Input.mousePosition.y);
			Vector2 objPos = Camera.main.ScreenToWorldPoint (mousePos);
		
			transform.position = new Vector2(transform.position.x, objPos.y);
		}
		//rb.velocity = (objPos - rb.position) * 50;

	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject.tag == "ZebraCrossing")
			OnZebraCrossing = true;

		if (col.gameObject.tag == "Car") {
			if(!OnZebraCrossing){
			SoundManager.PlaySound (fx_crash);
			zebra_anim.SetBool ("dead", true);
			dead = true;
				Invoke ("Lose",1f);
			}
		}

		if (col.gameObject.tag == "Finish")
			Invoke ("Win",0.5f);

	}

	void OnTriggerStay2D(Collider2D col){
		if (col.gameObject.tag == "ZebraCrossing")
			OnZebraCrossing = true;
	}
	void OnTriggerExit2D(Collider2D col){
			OnZebraCrossing = false;
	}

	void Win(){
		Sc_chooseButton.Win ();
	}

	void Lose(){
		Sc_chooseButton.ChangeScreen ();
	}
}

