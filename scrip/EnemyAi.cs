using System.Collections;

using UnityEngine;

public class EnemyAi : MonoBehaviour {
	
	public Transform Target;
	public float movementSpeed = 10f;
	public float MaxDis = 50f;
	public float MinDis = 20f;

	public int attackDamage = 10;

	public float AttackTime ;
	public float coolingdown;

	void Start()
	{
		AttackTime = 0;
		coolingdown = 2.0f;
	}

	void Update()
	{
		Move ();

	}

	void Move()
	{
		
		 if(Vector3.Distance(transform.position, Target.position) <=MaxDis)
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
		



		//transform.position += transform.forward * movementSpeed * Time.deltaTime;
	}


	public void attack()
	{
		 
		PlayerHealth Sh = Target.GetComponent<PlayerHealth> ();
		Sh.GetDamage (attackDamage);
		
	}



}