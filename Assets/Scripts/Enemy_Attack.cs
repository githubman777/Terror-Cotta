using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour {

public HudManager HudManager;
public int AttackDamage;

	// Use this for initialization
	void Start () {
		HudManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HudManager>();
	}
	
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player")){
			HudManager.UpdateHealth(AttackDamage);
		}
	}

	}

