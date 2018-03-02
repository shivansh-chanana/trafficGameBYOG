using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EazyTools.SoundManager;


public class Audio_MainMenu : MonoBehaviour {

	public AudioClip audio_MainMenu;

	// Use this for initialization
	void Start () {
		SoundManager.PlayMusic (audio_MainMenu,100,true,false);
	}
}
