using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontos : MonoBehaviour {

	public Text txtDistancia;
	public static float distancia;

	public Text txtScores;
	public static int points;

	//controla o inicio da contagem.
	private float controlerScore;

	// Use this for initialization
	void Start () {
		distancia = 0;
		points = 0;
		PlayerPrefs.SetFloat("Distancia", distancia);
		PlayerPrefs.SetInt("points", points);
		controlerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		txtDistancia.text = distancia.ToString();
		txtScores.text = points.ToString();
		controlerScore +=1 * Time.deltaTime;
		if(controlerScore >=5 ){
			distancia += 1 *Time.deltaTime; // multiplicar...
		}
	}
}
