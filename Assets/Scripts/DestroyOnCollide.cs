﻿using UnityEngine;

public class DestroyOnCollide : MonoBehaviour
{

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy(gameObject);
	}



}
