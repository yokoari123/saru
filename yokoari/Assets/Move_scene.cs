﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_scene : MonoBehaviour {
    public float time = 5;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Application.LoadLevel("Game over");
        }
    }
}
