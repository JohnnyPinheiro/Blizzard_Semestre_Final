using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pontos : MonoBehaviour {

	//Inative image buttons
	public Canvas Buttons;
	public Canvas Scores;
    


	public Text txtDistancia;
	public static float distancia;
	public static int txtDistance;

    public Text popUp;
	public static int txtPopUp;
	
	public Text txtScores;
	public static int points;
    public static int txtPoints;

	//controla o inicio da contagem.
	private float controlerScore;
	private float screenTime;
	private int txtTimeStart;

	// Use this for initialization
	void Start () {
		distancia = 0;
		txtDistance = 0;
        txtPoints = 0;
		screenTime =5;
		points = 0;
		PlayerPrefs.SetFloat("Distancia", distancia);
		PlayerPrefs.SetInt("points", points);
		controlerScore = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Colisor.isGame == true){
			txtDistancia.text = txtDistance.ToString();
			popUp.text = txtDistance.ToString();
        
			//timeStart.text = txtTimeStart.ToString();
			txtScores.text = points.ToString();
            DATACoins.Money = points;

            print("game : " +DATACoins.Money);
        controlerScore +=1 * Time.deltaTime;
			if(controlerScore >=5 ){
				distancia += 1 *Time.deltaTime *30; // multiplicar...
				txtDistance = (int) distancia;
				txtPopUp = (int) distancia;
			}
			Buttons.enabled = true;
			Scores.enabled = true;
		}else{
			Buttons.enabled = false;
			Scores.enabled = false;
		}
	}
}
