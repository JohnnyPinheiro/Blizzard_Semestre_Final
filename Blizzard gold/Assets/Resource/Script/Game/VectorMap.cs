using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
	//lista de pistas totais
	public GameObject[]Maps;
	//lista das pistas instanciadas e atualizadas
	List <GameObject> atual;
		static int num;

	// Use this for initialization
	void Start () {
		atual = new List<GameObject>();
		//Random.Range(0,4)
		//instancia 4 mapas iniciais para para fazer ficar fora do angulo da camera.
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position, Quaternion.identity));// passar sempre de padrão a fase inicial nesta posição.
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position+new Vector3(0,0,34), Quaternion.identity));//pode usar random
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position+new Vector3(0,0,68), Quaternion.identity));//pode usar random
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position+new Vector3(0,0,102), Quaternion.identity));//pode usar random
	}
	
	void Update () {
		//for de criação de mapa com movimentação  
		for(int i=0;i<atual.Count;i++){
			atual[i].transform.Translate(0,0,-0.1f);
			
			if(atual[i].transform.position.z < -34 ){
				Destroy(atual[i]);
				atual.Remove(atual[i]);
				//instancia outro

			//num = Random.Range(0,Maps.Length);
				atual.Add ((GameObject)Instantiate (Maps [0],transform.position+new Vector3(0,0,102), Quaternion.identity));

				break;
			}
		}

	}
}


