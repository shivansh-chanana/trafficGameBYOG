using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_RandomScene : MonoBehaviour {

	public static int randomSceneRange = 0;

	public void goToMenu(){
		SceneManager.LoadScene(0);
	}

	public void goToPreGameScene (){
		SceneManager.LoadScene(1);
	}

	#region Make Changes Together
	public static void RandomSceneSelection(){
		randomSceneRange = Random.Range (2,5);

		SceneManager.LoadScene(randomSceneRange);
		//SceneManager.LoadScene(4);	
	}

	public void RandomSceneSelectionForStartScreen(){
		randomSceneRange = Random.Range (2,5);

		SceneManager.LoadScene(randomSceneRange);
	//	SceneManager.LoadScene(4);	
	}
	#endregion

	public void ResetValues(){
		Sc_GameOver.remLife = 3;
	}

}
