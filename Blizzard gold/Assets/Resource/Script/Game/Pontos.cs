using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontos : MonoBehaviour {

	public Text txtDistancia;
	public static float distancia;
	public static int txtDistance;
	//public Text timeStart;

	public Text txtScores;
	public static int points;

	//controla o inicio da contagem.
	private float controlerScore;
	private float screenTime;
	private int txtTimeStart;

	// Use this for initialization
	void Start () {
		distancia = 0;
		txtDistance = 0;
		screenTime =5;
		points = 0;
		PlayerPrefs.SetFloat("Distancia", distancia);
		PlayerPrefs.SetInt("points", points);
		controlerScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		txtDistancia.text = txtDistance.ToString();
		//timeStart.text = txtTimeStart.ToString();
		txtScores.text = points.ToString();
		controlerScore +=1 * Time.deltaTime;
		if(controlerScore >=5 ){
			distancia += 1 *Time.deltaTime *30; // multiplicar...
			txtDistance = (int) distancia;

		}

	}
}
