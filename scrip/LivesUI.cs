using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class LivesUI : MonoBehaviour {

	public TextMesh livesText;

	void Update () {

		livesText.text = Playertstue.Lives.ToString() +" "+ "LIVES";
	
	}
}
