
using UnityEngine;

public class Target : MonoBehaviour {

	public GameObject deateeffact;
	public float health = 50f;
	private bool isDead = false;

	public void TakeDamage(float amount){
		health -= amount;
		if (health <= 0 && !isDead) {
			Die ();
		}
	
	}
	void Die()
	{
		isDead = true;
		GameObject effect = (GameObject)Instantiate (deateeffact, transform.position, Quaternion.identity);
		Destroy (effect, 5f);

		WaveSpawner.EnemiesAlive--;

		Destroy (gameObject);


	}

}
