using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour {

	public string menuSceneName = "Mainmemu";
	public string SelectLevel = "selectlevel";

	public void Continue(){

		SceneManager.LoadScene (SelectLevel);

	}


	public void Menu(){
		
		SceneManager.LoadScene (menuSceneName);

	}
}
