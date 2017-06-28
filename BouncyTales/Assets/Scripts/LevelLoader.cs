using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

			SceneManager.LoadScene (level);
		
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.name == "Player") {
			playerInGame = true;
		}
	}
}
