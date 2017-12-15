using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	public int health = 10;

	public bool isDead
	{
		get
		{ 
			return health <= 0;
		}

	}


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
