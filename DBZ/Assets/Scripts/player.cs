using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float moveSpeed, jumpPower, floorCheckRad;
	public Transform floorCheck;
	public LayerMask isFloor;
	private bool onFloor, jumped;
	private Rigidbody2D _player;
	// Use this for initialization
	void Start () {
		_player =  GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate() {
		onFloor = Physics2D.OverlapCircle (floorCheck.position, 
		floorCheckRad, isFloor);

	}
	// Update is called once per frame
	void Update () {

		if(onFloor) {
			jumped = false;
		}
		if(Input.GetKey (KeyCode.RightArrow )) {
			_player.velocity = new Vector2 (moveSpeed, _player.velocity.y) ;
		}
		if(Input.GetKey (KeyCode.LeftArrow )) {
			_player.velocity = new Vector2 (-moveSpeed, _player.velocity.y) ;
		}
		if(Input.GetKeyDown (KeyCode.UpArrow) && onFloor) {
			Jump();
		}
		if(Input.GetKeyDown (KeyCode.UpArrow) && !jumped && !onFloor) {
			Jump();
		}

	}

	public void Jump () {
		_player.velocity = new Vector2 (_player.velocity.x, jumpPower);
	}
}
