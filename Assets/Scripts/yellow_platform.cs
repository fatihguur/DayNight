using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yellow_platform : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;


	// Update is called once per frame
	void Update () {
		if (doorIsOpening == true) {
			Door.transform.Translate (Vector3.right * Time.deltaTime * 8);
		}

		if (Door.transform.position.x > 7.5f) {
			doorIsOpening = false;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2")
			doorIsOpening = true;
	}






}

