﻿using UnityEngine;
using System.Collections;
using System;

public class EscalaVR : MonoBehaviour, IGvrGazeResponder {

	public void OnGazeEnter() {
		transform.position += new Vector3 (1f, 0f, 0f);
	}

	public void OnGazeExit() {}

	public void OnGazeTrigger() {}
    
	void Start () {}

    void Update () {}
 } 
