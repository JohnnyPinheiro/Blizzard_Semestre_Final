using UnityEngine;
using System.Collections;
public class EscolhaDoPlayer : MonoBehaviour {
   
   public Texture[] Personagem;
   public Texture[] Names;
   private int SelecaoAtual;
   public GameObject cam;
   public Texture SelectCharacter;
   public float x;
   public float y;
   void Start (){
      SelecaoAtual = 0;

   }
  
   void OnGUI (){
      if(cam.transform.position.y >=20){
         GUI.enabled = true;
         //SELECAO DO PERSONAGEM
         if (GUI.Button (new Rect (Screen.width/ 12,Screen.height/1.7f,220,110), "")) {
            DATA.PersonagemAInstanciar = SelecaoAtual;
            // Application.LoadLevel("Mapa_Jogo"); // MUDAR O NOME DA CENA CONFORME O SEU JOGO
         }
         GUI.DrawTexture(new Rect(Screen.width/ 12,Screen.height/1.7f,220,110), SelectCharacter);//button select character
         //IFS
         if (SelecaoAtual == 0) {
            GUI.DrawTexture(new Rect(Screen.width/2f,Screen.height/15,250,400),Personagem[SelecaoAtual]);                                            
            //mudar selecao
            GUI.DrawTexture(new Rect(Screen.width/12.8f,Screen.height/15,235,75), Names[0]);
            if(GUI.Button (new Rect(Screen.width/1.22f,Screen.height/3f,100,160),"")){
               SelecaoAtual = SelecaoAtual +1;
            }
         }
         //
         if (SelecaoAtual > 0 && SelecaoAtual < (Personagem.Length - 1)) {
            GUI.DrawTexture(new Rect(Screen.width/2f,Screen.height/15,250,400),Personagem[SelecaoAtual]);                 
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            if(GUI.Button (new Rect(Screen.width/1.22f,Screen.height/3f,100,160),"")){
               SelecaoAtual = SelecaoAtual +1;
            }
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            if(GUI.Button (new Rect(Screen.width/3f,Screen.height/3f,100,160),"")){
               SelecaoAtual = SelecaoAtual -1;
            }
         }
         //
         if (SelecaoAtual >= (Personagem.Length - 1)) {
            //mudar selecao tamanho que vai aparecer o quadro da seleção
            GUI.DrawTexture(new Rect(Screen.width/2f,Screen.height/15,250,400),Personagem[SelecaoAtual]);
            //mudar selecao
            GUI.DrawTexture(new Rect(Screen.width/12.8f,Screen.height/15,235,75), Names[1]);//second characters name, 
            if(GUI.Button (new Rect(Screen.width/3f,Screen.height/3f,100,160),"")){
               SelecaoAtual = SelecaoAtual -1;
            }
         }
      }else{
          GUI.enabled = false;
      }
   }
}