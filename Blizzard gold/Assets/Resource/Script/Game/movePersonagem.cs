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
		rigd = GetComponent <Rigidbody>();
		animator = GetComponentInChildren<Animator>();
		inicio = false;
		controlarOStart = 0;
		start = 1;
		isMovingRight = false;
		isMovingLeft = false;
		Physics.gravity = new Vector3(0, -gravity, 0);
	}
	
	void Update () {

		controlarOStart = 6;	
		//Physics.gravity = new Vector3(0, -gravity, 0);
	
		//if (!inicio && Input.GetMouseButton (0)) {
			//rigd.AddForce(0,0,-80, ForceMode.Impulse);
			//inicio = true;
		//}
		
		Move ();
	}

	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.gameObject.tag == "Ground"){
			//so para voltar o pulo
			jump = false;
			animator.SetBool("isJump", false);
			Physics.gravity = new Vector3(0, -gravity, 0);
		}
	}

	public void jumping(){
		if(!jump){
			rigd.AddForce(0,forcejump,0, ForceMode.Impulse);
			jump = true;
			animator.SetBool("isJump", true);
			Physics.gravity = new Vector3(0, -gravity, 0);
		}
	}
	
	//Movimentacao com as animacoes
	public void Move(){
		if (isMovingRight) {
			rigd.velocity = new Vector3 (speed, rigd.velocity.y, rigd.velocity.z);
			if(!jump){
				animator.SetBool("isRight",true);
			}
		} else if(isMovingLeft){
			rigd.velocity = new Vector3 (-speed, rigd.velocity.y, rigd.velocity.z);
			if(!jump){
				animator.SetBool("isLeft",true);
			}
		} else{
			rigd.velocity = new Vector3 (0, rigd.velocity.y, rigd.velocity.z);
			animator.SetBool("isLeft", false);
			animator.SetBool("isRight",false);
		}
	}

	//controler buttons moviment character
	public void ControlerMovimentRight(){
		isMovingRight = true;
		//
	}

	public void ControlerMovingRightStop(){
		isMovingRight = false;
		//
	}

	public void ControlerMovimentLeft(){
		isMovingLeft = true;
		//
	}
	
	public void ControlerMovingLeftStop(){
		isMovingLeft = false;
		//
	}

}