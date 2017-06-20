using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	Text text;

	void Update () {
		text.text = "" + ScoreManager.score;
	}
}
