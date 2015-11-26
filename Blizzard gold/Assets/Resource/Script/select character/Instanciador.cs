using UnityEngine;
using System.Collections;
public class Instanciador : MonoBehaviour {
   public Vector3 PosicaoParaInstanciar;
   public float RotacaoEmX,RotacaoEmY,RotacaoEmZ;
   public GameObject[] Players;
   void Start () {
      Instantiate (Players [DATA.PersonagemAInstanciar], PosicaoParaInstanciar, Quaternion.Euler (RotacaoEmX, RotacaoEmY, RotacaoEmZ));                                      
   }
}