using UnityEngine;
using System.Collections;

public class ColoryGiro : MonoBehaviour {
	public delegate void metodoDelegado();
	public static metodoDelegado Evento;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		GetComponent<Renderer>().material.color = Color.blue;
		Evento ();
	}
}
