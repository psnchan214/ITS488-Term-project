
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmemu : MonoBehaviour {

	public string levelToload = "selectlevel";
	public SceneFader sceneFaer;

	public void Play()
	{
		sceneFaer.fadeTo (levelToload);
		SceneManager.LoadScene (levelToload);
	}

	public void Quit()
	{
		Debug.Log ("Exciting....");
		Application.Quit ();

	}
}
