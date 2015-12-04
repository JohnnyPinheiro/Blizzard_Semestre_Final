using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class Colisor : MonoBehaviour {

	//points
	public static int record;//public Text recordText;
	public static bool isGame;

	public Canvas NewRecord;
	private bool isRecord;

	void start(){
		PlayerPrefs.GetInt("recordPrefs"); //load no meu recorde
		record = PlayerPrefs.GetInt("recordPrefs");// passa o valor do meu recorde para a variavel record(que faz a comparação quando tem a colisão com o personagem)
		isRecord = false;
	}		


	void Update(){
		if(Colisor.isGame == false && isRecord){
			NewRecord.enabled = true;
		}else{
			NewRecord.enabled = false;
		}
	}


	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "GameOver"){
		//quando houver colisão	com algum obstaculo que faça ir para o game over
			isGame = false;
			PlayerPrefs.SetInt("scorePrefs", Pontos.txtDistance);//passo o valor de Pontos.points para o PlayerPrefs(scorePrefs)
			if(Pontos.txtDistance > PlayerPrefs.GetInt("recordPrefs")){//verifico se esta pontuação nova é maior que meu recorde
				PlayerPrefs.SetInt("recordPrefs", Pontos.txtDistance);//se for maior que meu recorde ele salva o novo recorde
				isRecord = true;
			}
		}else{
			isGame = true;
		}
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Coin"){
			Destroy(other.gameObject);//destroi o objeto coletado
			Pontos.points += 1; //faz a soma dos pontos em +1 toda vez que uma moeda é coletada
		}
	}
}
