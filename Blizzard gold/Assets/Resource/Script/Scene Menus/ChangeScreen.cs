using UnityEngine;
using System.Collections;

public class ChangeScreen : MonoBehaviour {

	public GameObject Cam;
	public Texture buttonBack;
	public float x;
	public float y;

	void OnGUI(){
		drawButtonBack(true);//botao de voltar das telas
		
	}


	void drawButtonBack(bool id){ //cria o botão voltar nas telas 
		if(Cam.transform.position.x ==0 && Cam.transform.position.y >=20 ||Cam.transform.position.x ==30 && Cam.transform.position.y >=0){
		    GUI.enabled = true;//faz o botão aparecer na tela
		    if(GUI.Button (new Rect (Screen.width/30,Screen.height/1.2f,100,80), "")){
		    	Cam.transform.position = new Vector3(0,0,0);
	     	}
        GUI.DrawTexture(new Rect(Screen.width/30,Screen.height/1.2f,100,80), buttonBack);
        }else{
        	GUI.enabled = false;// faz botão sumir da tela
        }
	}

}
