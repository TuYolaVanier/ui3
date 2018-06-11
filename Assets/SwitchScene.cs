using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchScene : MonoBehaviour {

	// This is a common used function that switches Scenes in "Scenes in Build"
	// The name of the scene(string SceneName) is wrote in "on click" of the botton
	public void GoScene (string SceneName) {
		SceneManager.LoadScene(SceneName);
	}
}