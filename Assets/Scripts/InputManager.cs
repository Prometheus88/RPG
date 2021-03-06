﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public static InputManager instance;

	public delegate void InputEvent();
	public static InputEvent OnPressDown;
	public static InputEvent OnPressUp;
	public static InputEvent OnTap;

	public float Timer = 10;
	// Use this for initialization
	void Start () {


		if (instance == null) {
			instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {


			if (OnPressUp != null) {
				WaitFor ();

			}
		}
	}

	IEnumerator WaitFor(){

		OnPressUp ();
		yield return new WaitForSeconds (0.3f);


	}


}
