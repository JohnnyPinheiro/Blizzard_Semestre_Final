using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainStart : MonoBehaviour {

	public GameObject cam;
	public GameObject splash;
	private float speed = .5f;
	private float z;
	

	private bool telaMenu = true;
	private bool telapersonagem = true;
	private bool telaShop = true;

	public Texture buttonPlay;
	public Texture buttonCharacter;
	public Texture buttonShop;

	void Update () {//verificador do menu p/frames
		//Splashscreen();
		ControllerCam();
	}


	void Splashscreen(){//passa a logo outline antes de menu principal
		z = transform.position.z;
		z += speed * Time.deltaTime;
		splash.transform.position = new Vector3(transform.position.x, transform.position.y, z);
	
		if (splash.transform.position.z >11){
			Destroy (splash);
		}
	}
	

	void OnGUI(){
		ButtonPlay();
		SelectCharacter();
		ButtonShop();
	}

	void ButtonPlay(){//da inicio ao jogo
		if(telaMenu){
			if(GUI.Button (new Rect (Screen.width/7,Screen.height/2f,230,50), "")){
				print("Start");	
				Application.LoadLevel("MAPA_JOGO");
		    }
	        GUI.DrawTexture(new Rect(Screen.width/7,Screen.height/2f,230,50), buttonPlay);
        }
	}

	void SelectCharacter(){//coloca o botao para ir para a tela de selecao de personagem
		if(telapersonagem){
			if(GUI.Button (new Rect (Screen.width/7,Screen.height/1.6f,230,50), "")){
				print("selecao de personagem");	
				cam.transform.position = new Vector3(0,20,0);
		 		telaMenu = false;
		 		telapersonagem = false;
		    }
	        GUI.DrawTexture(new Rect(Screen.width/7,Screen.height/1.6f,230,50), buttonCharacter);
        }
	}

	void ButtonShop(){
		if(telaShop){
			if(GUI.Button (new Rect (Screen.width/1.1f,Screen.height/1.2f,80,80), "")){
				cam.transform.position = new Vector3(30,0,0);
		 		telaMenu = false;
		 		telapersonagem = false;
		 		telaShop = false;
		    }
	        GUI.DrawTexture(new Rect(Screen.width/1.1f,Screen.height/1.2f,80,80), buttonShop);
        }
	}

	//verifica se esta na tela do menu principal para iniciar os botoes
	void ControllerCam(){
		if(cam.transform.position.x ==0 && cam.transform.position.y ==0){
			telaMenu = true;
			telapersonagem = true;
			telaShop = true;
			print("telaprincipal");
		}
	}
}
