using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Colisor : MonoBehaviour {

	//points
	public static int record;//public Text recordText;
	public static bool isGame;

    //coins
    public static int Coins;//public text coins text;

	public Canvas NewRecord;
	private bool isRecord;

    public Canvas CoinsColections;
    private bool isCoins;
	//
	public Canvas TempInit;
	public Canvas TxtGO;
	public Text CountInit;
	private float timeCount = 4f;
	private int timeCountGame;
	private float controlerMsgGo = 2f;
	public Text txtGo;

	//desativar button
	public Button Return;

	//Boosters Game
	public static bool isBooster;

	//Audio
	public AudioSource audio;
	public AudioClip coinSound;

	void start(){
		PlayerPrefs.GetInt("recordPrefs"); //load no meu recorde
		record = PlayerPrefs.GetInt("recordPrefs");// passa o valor do meu recorde para a variavel record(que faz a comparação quando tem a colisão com o personagem)
		isRecord = false;
		isBooster = false;
        isCoins = false;
        TempInit.enabled = true;
        

    
    }		


	void Update(){
		if(Colisor.isGame == false && isRecord){
			NewRecord.enabled = true;
          
		}else{
			NewRecord.enabled = false;
           
		}
        if(Colisor.isGame == false && isCoins)
        {
            CoinsColections.enabled = true;
        }
        else
        {
            CoinsColections.enabled = false;
        }
		TimerCountInit();
		MsgGo();
		
	}


	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "GameOver"){
		//quando houver colisão	com algum obstaculo que faça ir para o game over
			isGame = false;
			Return.enabled = false;
			Return.gameObject.SetActive(false);
            isCoins = true;
        
            PlayerPrefs.SetInt("scorePrefs", Pontos.txtDistance);//passo o valor de Pontos.points para o PlayerPrefs(scorePrefs)
          
            if (Pontos.txtDistance > PlayerPrefs.GetInt("recordPrefs")){//verifico se esta pontuação nova é maior que meu recorde
				PlayerPrefs.SetInt("recordPrefs", Pontos.txtDistance);//se for maior que meu recorde ele salva o novo recorde
				isRecord = true;
                
            }
		}else{
			isGame = true;
            
        }
	}

	void OnTriggerEnter(Collider other){
		if(other.tag == "Coin"){
			Destroy(other.gameObject);//destroi o objeto coletado
			Pontos.points += 1; //faz a soma dos pontos em +1 toda vez que uma moeda é coletada
			audio.PlayOneShot(coinSound,1);
		}
		if(other.tag == "Booster"){
			Destroy(other.gameObject);//destroi o objeto coletado
			print("Boster velocidade");
			isBooster = true;
		}if(other.tag == "Jump"){
			Destroy(other.gameObject);//destroi o objeto coletado
			print("Boster jump");
		}if(other.tag == "Shild"){
			Destroy(other.gameObject);//destroi o objeto coletado
			print("Boster defesa ou vida");
		}
	}

	void TimerCountInit(){
		if(timeCount >= 0){
			timeCount -= 1 * Time.deltaTime;
			CountInit.text = timeCountGame.ToString();
			timeCountGame = (int) timeCount;
		}else{
			TempInit.enabled = false;
			TxtGO.enabled = true;
		}
	}

	void MsgGo(){
		if(controlerMsgGo >= 0 && timeCount<0 ){
			controlerMsgGo -= 1*Time.deltaTime;
			txtGo.text = "GO";
		}else{
			TxtGO.enabled = false;
		}
	}

    
}
