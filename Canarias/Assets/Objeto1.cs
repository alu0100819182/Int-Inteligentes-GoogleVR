using UnityEngine;
using System.Collections;

public class Objeto1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		ColoryGiro.Evento += metodoEjecutar;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void metodoEjecutar() {
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}
}
