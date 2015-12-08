using UnityEngine;
using System.Collections;

public class MenuStart : MonoBehaviour {

  	//PopUps
	public Canvas popUpShop;
	public Canvas popUpInformations;
	public Canvas popUpExit;

	//testures buttons
	public Texture TexturePlay;
	public Texture TextureShop;
	public Texture TextureInfo;
	public Texture TextureExit;
	public Texture TextureSoundOn;
	public Texture TextureSoundOff;
	
	
	//controladores
	private static int controllerPopUp;
	public static bool music;

	void Start(){
		controllerPopUp = 0;
		music = true;
	}

	void Update(){

		if (controllerPopUp == 0) {//Menu
			popUpExit.enabled = false;
			popUpInformations.enabled = false;
			popUpShop.enabled = false;
		} else if (controllerPopUp == 1) {//PopUp Shop
			popUpExit.enabled = false;
			popUpInformations.enabled = false;
			popUpShop.enabled = true;

		} else if (controllerPopUp == 2) {//PopUp Information
			popUpExit.enabled = false;
			popUpInformations.enabled = true;
			popUpShop.enabled = false;
		} else if (controllerPopUp == 3){//PopUp Exit
			popUpExit.enabled = true;
			popUpInformations.enabled = false;
			popUpShop.enabled = false;
		}
	}
	
	void OnGUI(){
		//manda para a tela de jogo
		if(moveSplash.isSplash == true){
			if(controllerPopUp == 0 ){
				if (GUI.Button(new Rect((Screen.width/2)-100,(Screen.height/2)-100, 200, 200), " ")){
					Application.LoadLevel("Game");
				}
				GUI.DrawTexture(new Rect((Screen.width/2)-85,(Screen.height/2)-85, 170, 170), TexturePlay);
				//abrira um pop up para shop
				if (GUI.Button(new Rect(0,0, 100, 100), TextureShop)){
					print ("shop");
					controllerPopUp = 1;
				}
				//abrira um pop up para as informaçoes
				if (GUI.Button(new Rect((Screen.width-100),(Screen.height-100), 100, 100), TextureInfo)){
					print ("informaçoes");
					controllerPopUp = 2;
				}
				//abrira um pop up para fechar o game
				if (GUI.Button(new Rect(0,(Screen.height-100), 100, 100), TextureExit)){
					print ("fecha game");
					controllerPopUp = 3;
				}
			}
			// liga e deslida a musica do jogo;
			/*if (GUI.Button(new Rect((Screen.width-100),0, 100, 100), TextureSoundOn)){
				if(music){
					music = false;
				}else if(!music){
					music = true;
				}
			}*/
		}
	}

	public void Exit(){
		Application.Quit ();
	}

	public void ClosePopUp(){
		controllerPopUp = 0;
	}

	
}
