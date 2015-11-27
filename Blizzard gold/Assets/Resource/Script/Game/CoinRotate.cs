using UnityEngine;
using System.Collections;

public class CoinRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 10, 0, Space.World);
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
}
