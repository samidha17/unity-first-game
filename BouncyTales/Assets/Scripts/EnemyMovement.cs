using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

	public float moveSpeed;
	public bool moveRight;
	public bool moveUp;

	public Transform wallCheck;
	public Transform wallBox;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		hittingWall = Physics2D.OverlapBox (wallBox.position, wallBox.lossyScale, 90, whatIsWall);

		if (hittingWall)
			moveRight = !moveRight;

		if (moveRight) {
			
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D> ().velocity.y); 
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D> ().velocity.y); 
		}

		if (moveUp) {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, moveSpeed); 
		} else {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, moveSpeed); 
		}




	}


}
