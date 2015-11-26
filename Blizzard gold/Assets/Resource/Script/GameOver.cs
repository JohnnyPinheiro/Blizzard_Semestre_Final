using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public Text scoreText;
	public Text recordText;

	void Start(){
		scoreText.text = PlayerPrefs.GetInt("scorePrefs").ToString();//carrega a pontuação da ultima jogada
		recordText.text = PlayerPrefs.GetInt("recordPrefs").ToString();// carrega a maior pontuação

	}

	void Update () {
		if(Input.GetMouseButtonDown(0)){
			Application.LoadLevel("MenuIniciar");
		}
	
	}
}
