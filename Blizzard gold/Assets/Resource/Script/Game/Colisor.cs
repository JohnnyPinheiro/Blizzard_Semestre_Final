using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class Colisor : MonoBehaviour {

	//points
	public static int record;//public Text recordText;
	
	void start(){
		PlayerPrefs.GetInt("recordPrefs"); //load no meu recorde
		record = PlayerPrefs.GetInt("recordPrefs");// passa o valor do meu recorde para a variavel record(que faz a comparação quando tem a colisão com o personagem)
	}

	

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "GameOver"){
		//quando houver colisão	com algum obstaculo que faça ir para o game over
			PlayerPrefs.SetInt("scorePrefs", Pontos.points);//passo o valor de Pontos.points para o PlayerPrefs(scorePrefs)
			if(Pontos.points > PlayerPrefs.GetInt("recordPrefs")){//verifico se esta pontuação nova é maior que meu recorde
				PlayerPrefs.SetInt("recordPrefs", Pontos.points);//se for maior que meu recorde ele salva o novo recorde
			}
			Application.LoadLevel("GameOver");
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Coin"){
			Destroy(other.gameObject);//destroi o objeto coletado
			Pontos.points += 1; //faz a soma dos pontos em +1 toda vez que uma moeda é coletada
		}
	}
}
