using System.Collections;
using UnityEngine;

public class Turrt : MonoBehaviour {
	public Transform Door;

	public float MaxDis = 50f;
	public int attackDamage = 10;
	public float AttackTime ;
	public float coolingdown;

	void Start () 
	{
		AttackTime = 0;
		coolingdown = 2.0f;

	}
		
	void Update () {

		Move ();
		
	}

	void Move()
	{

		if(Vector3.Distance(transform.position, Door.position) <=MaxDis)
		{
			if(AttackTime>0){
				AttackTime -= Time.deltaTime;
			}
			if (AttackTime < 0) {
				AttackTime = 0;
			}
			if (AttackTime == 0) {
				attack ();
				AttackTime = coolingdown;
			}

		}
			
	}

	public void attack()
	{

		PlayerHealth Sh = Door.GetComponent<PlayerHealth>();
		Sh.GetDamage (attackDamage);

	}

}
