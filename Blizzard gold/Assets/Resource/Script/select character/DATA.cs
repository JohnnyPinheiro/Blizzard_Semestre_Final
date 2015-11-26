using UnityEngine;
using System.Collections;
public class DATA : MonoBehaviour {
   private GameObject[] Datas;
   public static int PersonagemAInstanciar;
   void Awake (){
      Datas = GameObject.FindGameObjectsWithTag ("DATA");
      if (Datas.Length >= 2) {
         Destroy(Datas[0]);
      }
      DontDestroyOnLoad (transform.gameObject);
   }
}