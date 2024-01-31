using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6green : MonoBehaviour {

	public GameObject Door;
	public GameObject Door2;
	public bool doorIsOpening;



	void Update(){
		if (doorIsOpening == true) {
			Door.transform.Translate (-Vector3.right * Time.deltaTime * 3);


		}

		if (Door.transform.position.x < 14.8f) {
			doorIsOpening = false;
		}

		if (doorIsOpening == true) {
			Door2.transform.Translate (Vector3.right * Time.deltaTime * 3);
		
		}
	}





	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "greenball")
			doorIsOpening = true;





	}
}











