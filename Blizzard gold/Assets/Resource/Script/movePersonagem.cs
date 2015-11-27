using UnityEngine;
using System.Collections;
//using UnityStandardAssets.CrossPlatformInput;

public class movePersonagem : MonoBehaviour {

	Rigidbody rigd;
	public float speed;
	Animator animator;
	
	private bool jump;
	public float gravity;
	private bool inicio;
	public float forcejump;

	private float controlarOStart;
	private float start;

	//controler moviments
	private bool isMovingRight;
	private bool isMovingLeft;
	
	
	void Start () {
		//Physics.gravity = new Vector3(0, -gravity, 0);
		//rigd = GetComponentInParent <Rigidbody>();
		rigd = GetComponent <Rigidbody>();
		animator = GetComponentInChildren<Animator>();
		inicio = false;
		controlarOStart = 0;
		start = 1;
		isMovingRight = false;
		isMovingLeft = false;
	}
	
	void Update () {
		controlarOStart = 6;	
		Physics.gravity = new Vector3(0, -gravity, 0);
		//movimentation();
	//	MoveJoy();

		//if (!inicio && Input.GetMouseButton (0)) {
			//rigd.AddForce(0,0,-80, ForceMode.Impulse);
			//inicio = true;
		//}
		print (isMovingRight);
		Left ();
		Right ();
	}

	/*void movimentation(){
		if(Input.GetKey(KeyCode.A)){
			rigd.velocity = new Vector3(-speed, rigd.velocity.y,rigd.velocity.z);
				if(!jump){
					animator.SetBool("left",true);
				}
		}else if(Input.GetKey(KeyCode.D)){
			rigd.velocity = new Vector3(speed, rigd.velocity.y,rigd.velocity.z);
				if(!jump){
					animator.SetBool("right",true);
				}
		}else{
			rigd.velocity = new Vector3(0, rigd.velocity.y,rigd.velocity.z);
			animator.SetBool("left", false);
			animator.SetBool("right",false);
		}


		if(!jump && Input.GetKeyDown(KeyCode.Space)){
			rigd.AddForce(0,forcejump,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("jump", true);
		}
	}*/

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "Ground"){
		//so para voltar o pulo
			//jump = false;
			animator.SetBool("jump", false);
			Physics.gravity = new Vector3(0, -gravity, 0);
		}

	}

	/*public void jumping(){
		if(!jump){
			rigd.AddForce(0,forcejump,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("jump", true);
			Physics.gravity = new Vector3(0, -gravity, 0);
		}
	}*/
	public void Right(){
		if (isMovingRight) {
			rigd.velocity = new Vector3 (speed, rigd.velocity.y, rigd.velocity.z);

		} else {
			rigd.velocity = new Vector3 (0, rigd.velocity.y, rigd.velocity.z);
		}
	}

	public void Left(){
		if (isMovingLeft) {
			rigd.velocity = new Vector3 (-speed, rigd.velocity.y, rigd.velocity.z);
			
		} else {
			rigd.velocity = new Vector3 (0, rigd.velocity.y, rigd.velocity.z);
		}
	}


	public void ControlerMovimentRight(){
		isMovingRight = true;
	}

	public void ControlerMovingRightStop(){
		isMovingRight = false;
	}

	public void ControlerMovimentLeft(){
		isMovingLeft = true;
	}
	
	public void ControlerMovingLeftStop(){
		isMovingLeft = false;
	}

}