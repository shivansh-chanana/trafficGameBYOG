using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_RandomScene : MonoBehaviour {

	int randomSceneRange = 0;

	public void goToMenu(){
		SceneManager.LoadScene(0);
	}

	public void goToPreGameScene (){
		SceneManager.LoadScene(1);
	}

	public void RandomSceneSelection(){
		randomSceneRange = Random.Range (2,7);

		SceneManager.LoadScene(randomSceneRange);
	}

}
