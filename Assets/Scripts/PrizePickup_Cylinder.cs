using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class PrizePickup_Cylinder : MonoBehaviour {

public HudManager HudManager;
public ThirdPersonCharacter ThirdPersonCharacter;

	
void Start(){
	HudManager = GameObject.FindGameObjectWithTag("Player").GetComponent<HudManager>();

ThirdPersonCharacter = GameObject.FindGameObjectWithTag ("Player")
.GetComponent<ThirdPersonCharacter> ();
}

void OnTriggerEnter(Collider other){
	if(other.gameObject.CompareTag("Player")){
		gameObject.SetActive (false);
		HudManager.UpdateScore(100);
		ThirdPersonCharacter.m_MoveSpeedMultiplier+=2;
		ThirdPersonCharacter.m_JumpPower+=10;
	}
}
}
