using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunrotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		_yawer = GetComponent<CharacterController> ();
	}
		
	public float Speed = 2f;
	public float senstivety = 2f;
	CharacterController _yawer;

	public GameObject MC;

	float moveFB;
	float moveLR;
	float rotx;
	float roty;


	void Update() {
		moveFB = Input.GetAxis ("Vertical") * Speed;
		moveLR = Input.GetAxis ("Horizontal") * Speed;

		rotx = Input.GetAxis ("Mouse X") * senstivety;
		roty = Input.GetAxis ("Mouse Y") * senstivety;

		Vector3 movement = new Vector3 (moveLR, 0, moveFB);
		transform.Rotate (0,rotx,0);
		MC.transform.Rotate (-roty,0,0);

		movement = transform.rotation * movement;
		//weap.Move(movement * Time.deltaTime);

	}
}
