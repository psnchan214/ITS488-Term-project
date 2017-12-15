using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public Transform Target;
	public float roatationalDamp = .5f;
	public float movementSpeed = 10f;

	void Update()
	{
		Turn ();
		Move ();
	}

	void Turn()
	{
		Vector3 pos = Target.position - transform.position;
		pos.y = 0;
		Quaternion rotation = Quaternion.LookRotation (pos);
		transform.rotation = Quaternion.Slerp (transform.rotation, rotation, roatationalDamp * Time.deltaTime);
	}

	void Move()
	{
		transform.position += transform.forward * movementSpeed * Time.deltaTime;
	}

}
