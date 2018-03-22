using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour {

	public int score;
public Text ScoreText;
public Slider HealthBar; 

public int StartingHealth;
public int CurrentHealth;



	void Start (){
score = 0;
ScoreText.text = "Score: " + score;
CurrentHealth = StartingHealth;
HealthBar.value = CurrentHealth;
	}

	public void UpdateScore(int amount){
score = score + amount;
ScoreText.text = "Score: " + score;
	}
public void UpdateHealth(int amount){
	CurrentHealth -= amount;
	HealthBar.value = CurrentHealth;
	if(CurrentHealth <=0){
Die();
	}

}

void Die(){
SceneManager.LoadScene("Level_01");
}

	}
