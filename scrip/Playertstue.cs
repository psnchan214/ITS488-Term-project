using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertstue : MonoBehaviour {
	public static int Lives;
	public int startLives = 10;
	public static int Rounds;

	void Start () {

		Lives = startLives;
		Rounds = 0;
	}


}
