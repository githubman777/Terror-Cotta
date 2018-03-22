using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEnemy : MonoBehaviour {

	public int AttackDamage;

	void OnTriggerEnter(Collider other){
		EnemyHealth EnemyHealth = other.GetComponent<EnemyHealth>();

		if(EnemyHealth != null){
			EnemyHealth.UpdateHealth(AttackDamage);
		}
	}
}

	

