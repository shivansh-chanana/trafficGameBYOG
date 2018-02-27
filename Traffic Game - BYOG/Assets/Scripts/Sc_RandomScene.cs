using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_RandomScene : MonoBehaviour {

	public static int randomSceneRange = 0;

	public static int tempOldScene = 0;

	public void goToMenu(){
		SceneManager.LoadScene(0);
	}

	public void goToPreGameScene (){
		SceneManager.LoadScene(0);
	}

	#region Make Changes Together
	public static void RandomSceneSelection(){
		#region noScene Repeat
		randomSceneRange = Random.Range (2,7);
		if (tempOldScene != 0) {
			for (; tempOldScene == randomSceneRange;)
				randomSceneRange = Random.Range (2, 7);
		}
		tempOldScene = randomSceneRange;
		#endregion
		Sc_TimerBar.time = 10;
		SceneManager.LoadScene(randomSceneRange);
	}

	public void RandomSceneSelectionForStartScreen(){
		noSceneRepeat ();
		Sc_TimerBar.time = 10;
		SceneManager.LoadScene(randomSceneRange);
	}
	#endregion

	void noSceneRepeat(){
		randomSceneRange = Random.Range (2,7);
		if (tempOldScene != 0) {
			for (; tempOldScene == randomSceneRange;)
				randomSceneRange = Random.Range (2, 7);
		}
		tempOldScene = randomSceneRange;
	}


	public void ResetValues(){
		Sc_GameOver.remLife = 3;
	}


}
