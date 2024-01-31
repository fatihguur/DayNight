using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketetcek5 : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;


	void Update(){
		if (doorIsOpening == true) {
			Door.transform.Translate (Vector3.right * Time.deltaTime * 3);

		}

		if (Door.transform.position.x > 13.5f) {
			doorIsOpening = false;
		}

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2")
			doorIsOpening = true;
	}





}
