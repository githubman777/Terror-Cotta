using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrizePickup : MonoBehaviour {

	public HudManager HudManager;
	
void Start(){
	HudManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HudManager>();

}

void OnTriggerEnter(Collider other){
	if(other.gameObject.CompareTag("Player")){
		gameObject.SetActive (false);
		HudManager.UpdateScore(100);
	}
}

	}
