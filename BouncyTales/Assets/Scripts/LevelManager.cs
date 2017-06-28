using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	public int pointPenaltyOnDeath;

	private PlayerController player;

	public HealthManager healthManager;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		healthManager = FindObjectOfType<HealthManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void RespawnPlayer()
	{
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;

		ScoreManager.AddPoints (-pointPenaltyOnDeath);
	}

}
