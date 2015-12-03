using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PopUp : MonoBehaviour {

	public Texture aTexture;
	public Texture TextureRestart;
	public Texture TextureMenu;
	
	void OnGUI(){
		if(Colisor.isGame == true){
			GUI.DrawTexture(new Rect(Screen.width/7,Screen.height/5, 800, 510), aTexture);
		
			if (GUI.Button(new Rect((Screen.width/2)-50,Screen.height/1.5f, 150, 80), TextureRestart)){
				Application.LoadLevel(Application.loadedLevel);
			}
			if (GUI.Button(new Rect((Screen.width/2)-50,Screen.height/1.25f, 150, 80), TextureMenu)){
				Application.LoadLevel("Menu");
			}
				
			//organizar na tela para ficar centralizado, vai fazer aparecer os resultados no pop up
			GUI.Label(new Rect(10, 10, 100, 20), PlayerPrefs.GetInt("scorePrefs").ToString());
			GUI.Label(new Rect(100, 10, 100, 20), PlayerPrefs.GetInt("recordPrefs").ToString());
		}
	}


}
