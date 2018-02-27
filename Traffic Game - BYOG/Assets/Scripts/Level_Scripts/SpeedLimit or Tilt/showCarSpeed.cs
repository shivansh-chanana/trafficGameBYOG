using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class showCarSpeed : MonoBehaviour {

	public Text speedShow;

	double speed = 0;

	// Update is called once per frame
	void Update () {

		speed = Math.Round(carController.speed * 100f,0);

		speedShow.text = speed.ToString();
	}
}
