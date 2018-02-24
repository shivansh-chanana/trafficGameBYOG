using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_RandomScene : MonoBehaviour {

	public int randomSceneRange = 0;

	public void RandomSceneSelection(){
		randomSceneRange = Random.Range (2,7);

		SceneManager.LoadScene(randomSceneRange);
	}

}
