using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidade : MonoBehaviour {

	public float Speed = 10f;

	private Rigidbody2D _rigidbody2D;
	// Use this for initialization
	private void Start ()
	{
		_rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void FixedUpdate ()
	{
		var pos = new Vector3(Speed * Time.fixedDeltaTime, 0.0f, 0.0f) + transform.position;
		_rigidbody2D.MovePosition(pos);
	}
}
