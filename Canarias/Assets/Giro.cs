using UnityEngine;
using System.Collections;

public class Giro : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter(Collision collision) {
		transform.Rotate(0, 90, 0);
	}
}
