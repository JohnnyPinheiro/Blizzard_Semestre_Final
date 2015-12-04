using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUp : MonoBehaviour {

	public Texture TextureRestart;
	public Texture TextureMenu;
	public Texture TextureShop;

	public Canvas popUp;

	void Update(){
		if(Colisor.isGame == false){
			popUp.enabled = true;
		}else{
			popUp.enabled = false;
		}
	}

	void OnGUI(){
		
		if(Colisor.isGame == false){
			if (GUI.Button(new Rect((Screen.width/2)-50,Screen.height/1.5f, 80, 80), TextureRestart)){
				Application.LoadLevel(Application.loadedLevel);
			}
			if (GUI.Button(new Rect((Screen.width/5),Screen.height/1.5f, 80, 80), TextureMenu)){
				Application.LoadLevel("Menu");
			}
			if (GUI.Button(new Rect((Screen.width/1.4f),Screen.height/1.5f, 80, 80), TextureShop)){
				Application.LoadLevel("Menu");
			}
		}
	}
}
