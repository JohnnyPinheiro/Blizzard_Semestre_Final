using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontos : MonoBehaviour {

	public Text txtDistancia;
	public static int distancia;

	public Text txtScores;
	public static int points;


	

	// Use this for initialization
	void Start () {
		distancia = 0;
		points = 0;
		PlayerPrefs.SetInt("Distancia", distancia);
		PlayerPrefs.SetInt("points", points);
	}
	
	// Update is called once per frame
	void Update () {
		txtDistancia.text = distancia.ToString();
		distancia ++;
		txtScores.text = points.ToString();
	}
	

	
}
