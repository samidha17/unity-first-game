using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePickUp : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<PlayerController> () == null)
			return;

		HealthManager.playerHealth += 1;

		Destroy (gameObject);
	}
}
