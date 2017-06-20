using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

	private bool playerInGame;

	public string level;

	// Use this for initialization
	void Start () {
		playerInGame = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (playerInGame) {

			Application.LoadLevel(level);
		
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "Player") {
			playerInGame = true;
		}
	}
}
