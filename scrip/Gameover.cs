using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour {


	public string menuSceneName = "Mainmemu";
	public void Retry()

	{

		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

	}


	public void Memu()

	{

		SceneManager.LoadScene (menuSceneName);

	}
}
