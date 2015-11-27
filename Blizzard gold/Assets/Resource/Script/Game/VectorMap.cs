using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VectorMap : MonoBehaviour {
//maps inclinado	
	//lista de pistas totais
	public GameObject[]Maps;
	//lista das pistas instanciadas e atualizadas
	static List <GameObject> atual;
	static public int count;
	static public int size=2500;
	static int num;
	private static int i;


	// Use this for initialization
	void Start () {
	   count=0;
	   i = 0;
		atual = new List<GameObject>();
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position, Maps [0].transform.rotation));
		atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(-0,-3.1f,35) , Maps [0].transform.rotation));
	}
	
	void Update(){
		CreateMap();
	}

	public  void CreateMap(){
	if (i >= 20) {
	//controlador
		i = 21;
		} else {
			for (i = 1; i <= 20; i++) {
				atual.Add ((GameObject)Instantiate (Maps [0],transform.position + new Vector3(-0*i,-3.1f*i,35*i) , Maps [0].transform.rotation));
			}
		}
	}


}


