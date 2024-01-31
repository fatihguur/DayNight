using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brokenfloor2 : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2") {
			Destroy (GameObject.FindGameObjectWithTag("brokenfloor2"));
		}
}
}
