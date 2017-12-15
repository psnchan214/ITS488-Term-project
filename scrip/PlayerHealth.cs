using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public int MaxHealth = 100;
	public int currentHealth ;


	public void GetDamage(int amount){
		MaxHealth -= amount;
		if (MaxHealth <= 0) {
			Die ();
			Debug.Log ("Dead!");
		} 

	}
	void Die()
	{
		Destroy (gameObject);
	}


}
