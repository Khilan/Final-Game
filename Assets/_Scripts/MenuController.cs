﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {


	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartButtonClick(){
		SceneManager.LoadScene ("Level1");
	}

	public void InstructionButtonClick(){
		SceneManager.LoadScene ("Instruction");
	}

	public void QuitButtonClick(){
		Application.Quit ();
	}

}
