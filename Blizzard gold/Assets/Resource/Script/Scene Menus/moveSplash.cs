using UnityEngine;
using System.Collections;

public class moveSplash : MonoBehaviour {

	private float speed = 4f;
	private float z;
	public static bool isSplash;

	void Update () {
		z = transform.position.z;
		z += speed * Time.deltaTime;
		transform.position = new Vector3(transform.position.x, transform.position.y, z);
	
		if (transform.position.z >100){
			Destroy (gameObject);
			isSplash = true;
		}
	}
}
