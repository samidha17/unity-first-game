using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {

	public string mainMenu;

	public int maxPlayerHealth;

	public static int playerHealth;

	Text text;

	private LevelManager levelManager;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();

		playerHealth = maxPlayerHealth;

		levelManager = FindObjectOfType<LevelManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth <= 0) {

			SceneManager.LoadScene (mainMenu);
		}

		text.text = "" + playerHealth;
	}
		
	public static void HurtPlayer(int damageToGive)
	{
		playerHealth -= damageToGive;

	}

	public void FullHealth()
	{
		playerHealth = maxPlayerHealth;
	}

}
