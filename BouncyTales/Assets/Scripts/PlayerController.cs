using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float moveSpeed;
	public float jumpHeight;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;

	private int count;

	// Use this for initialization
	void Start () {

	}

	void FixedUpdate () {
	
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Coins"))
		{
			other.gameObject.SetActive (false);
			count = count + 1;
		}
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Space) && grounded)
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);

		}

		if(Input.GetKey (KeyCode.D) )
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}

		if(Input.GetKey (KeyCode.A) )
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}

	}
}
