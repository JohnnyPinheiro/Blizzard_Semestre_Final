using UnityEngine;
using System.Collections;

public class MenuStart : MonoBehaviour {

	public Texture TexturePlay;
	
	void OnGUI(){
		if (GUI.Button(new Rect((Screen.width/2)-150,(Screen.height/2)-80, 150, 80), TexturePlay)){
			Application.LoadLevel("Game");
		}
	}
}
