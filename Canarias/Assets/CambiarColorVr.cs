using UnityEngine;
using System.Collections;

public class CambiarColorVr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void cambioColor() {
		GetComponent<Renderer>().material.color = Color.blue;
	}
}
