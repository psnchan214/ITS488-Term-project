
using UnityEngine;

public class Gunscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}




	public float damage = 10f;
	public float range = 100f;
	public Camera fpsCam;
	public GameObject imapctEffect;
	public ParticleSystem muzzleFlash;

	void Update () {

		if (Gamemaneger.GameIsOver) {
			this.enabled = false;
			return;
		}

		if(Input.GetButtonDown("Fire1"))
		{
			shoot ();
		}
		
	}

	void shoot()
	{
		muzzleFlash.Play();
		RaycastHit hit;
		if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
		{
			Debug.Log (hit.transform.name);
			Target target = hit.transform.GetComponent<Target> ();
			if (target != null) {
				target.TakeDamage (damage);
			}


			GameObject imapctGo = Instantiate(imapctEffect, hit.point, Quaternion.LookRotation (hit.normal));
			Destroy(imapctGo, 2f);
		}
	}
}
