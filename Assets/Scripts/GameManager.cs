﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	private GameObject player, settingsObject;
	private GameSettings settings;
	private Player playerScript;

	private float innerTimer, totalTimer = 0;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerScript = player.GetComponent<Player> ();

		settingsObject = GameObject.Find ("GameSettings");
		settings = settingsObject.GetComponent<GameSettings> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Checks if player is on center
		// Use World to Viewport Point (Close to 0,5);
		// if it is, nudges the player on a random direction on random timespaces

		innerTimer += Time.deltaTime;
		totalTimer += Time.deltaTime;

		if (innerTimer >= settings.nudgeInterval) {
			playerScript.ReceiveNudge (1, UsefulFunctions.GetRandomBoolean ());
			innerTimer = 0;
		}
	}
}
