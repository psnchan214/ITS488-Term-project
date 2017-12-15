using UnityEngine;

public class Levelselect : MonoBehaviour {

	public SceneFader fader;

	public void Select (string levelName){
		fader.fadeTo(levelName);
	}
	 
}
