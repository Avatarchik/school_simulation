﻿using UnityEngine;
using System.Collections;

public class Init : MonoBehaviour {
    void Awake(){
		Dialoguer.Initialize ();
		}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
				if (GUI.Button (new Rect (10, 10, 100, 20), "Начать Игру")) {
						Dialoguer.StartDialogue (0, dialoguerCallback);
			this.enabled=false;
				}
		}
	private void dialoguerCallback(){
		this.enabled = true;
		}
}