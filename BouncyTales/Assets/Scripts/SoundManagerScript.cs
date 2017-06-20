using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip coin, bomb;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

		coin = Resources.Load<AudioClip> ("coin");
		bomb = Resources.Load<AudioClip> ("bomb");

		audioSrc = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "coin":
			audioSrc.PlayOneShot (coin);
			break;
		case "bomb":
			audioSrc.PlayOneShot (bomb);
			break;

		}
	}
}
