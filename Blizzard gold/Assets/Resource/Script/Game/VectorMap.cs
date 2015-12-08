using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
	
	//lista de pistas totais
	public GameObject[]Maps;
	
	//lista das pistas instanciadas e atualizadas
	List <GameObject> atual;
	static int num;

	//acelerador
	private float acelera;
	private float controlerTimer;
	private float aceleraBoster;

	// Use this for initialization
	void Start () {
		atual = new List<GameObject>();
		//Random.Range(0,4)
		//instancia 4 mapas iniciais para para fazer ficar fora do angulo da camera.
		atual.Add ((GameObject)Instantiate (Maps [1],transform.position, Quaternion.identity));// passar sempre de padrão a fase inicial nesta posição.
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position+new Vector3(0,0,34f), Quaternion.identity));//pode usar random
		atual.Add ((GameObject)Instantiate (Maps [2],transform.position+new Vector3(0,0,68f), Quaternion.identity));//pode usar random
		atual.Add ((GameObject)Instantiate (Maps [2],transform.position+new Vector3(0,0,102f), Quaternion.identity));//pode usar random
		acelera = -0.1f;
		controlerTimer = 3;
		aceleraBoster = 0;
	}
	
	void Update () {
		//for de criação de mapa com movimentação  
		if(Colisor.isGame == true){
			if(Colisor.isBooster ==  true && controlerTimer >= 0){//almenta a velocidade por 3segundos quando pega o booster 
				controlerTimer -=1 *Time.deltaTime;
				aceleraBoster = acelera*2; 
			}else{
				Colisor.isBooster = false;
				acelera -= 0.001f * Time.deltaTime; //acelerando o game aos poucos
				controlerTimer =3;
			}
			for(int i=0;i<atual.Count;i++){
				if(Colisor.isBooster){
					atual[i].transform.Translate(0,0,aceleraBoster);
				}else{
					atual[i].transform.Translate(0,0,acelera);
				}
				if(atual[i].transform.position.z < -34f ){
					Destroy(atual[i]);
					atual.Remove(atual[i]);
					//instancia outro

					num = Random.Range(2,Maps.Length);
					atual.Add ((GameObject)Instantiate (Maps [num],transform.position+new Vector3(0,0,102f), Quaternion.identity));
					break;
				}
			}
		}
	}
}


