using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	public float moveSpeed;
	public float jumpPower;

	private Rigidbody2D _player;
	// Use this for initialization
	void Start () {
		_player =  GetComponent<Rigidbody2D> ();
	}
	 
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.RightArrow )) {
			_player.velocity = new Vector2 (moveSpeed, _player.velocity.y) ;
		}
		if(Input.GetKey (KeyCode.LeftArrow )) {
			_player.velocity = new Vector2 (-moveSpeed, _player.velocity.y) ;
		}
		if(Input.GetKeyDown (KeyCode.UpArrow)) {
			Jump();
		}
	}

	public void Jump () {
		_player.velocity = new Vector2 (_player.velocity.x, jumpPower);
	}
}
