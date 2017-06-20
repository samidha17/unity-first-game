﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int pointsToAdd;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerController> () == null)
			return;

		ScoreManager.AddPoints (pointsToAdd);

		SoundManagerScript.PlaySound ("coin");

		Destroy (gameObject);
	}
}
