using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyHealth : MonoBehaviour {

public int StartingHealth;
public int CurrentHealth;
public Transform drop;

	// Use this for initialization
	void Start () {
		CurrentHealth = StartingHealth;
	}
	
	public void UpdateHealth(int amount){
		CurrentHealth -= amount;
		if(CurrentHealth <= 0){
			Die();
		}
	}

	void Die(){
		gameObject.SetActive(false);
		Instantiate(drop, transform.position, Quaternion.identity);
	}
}
