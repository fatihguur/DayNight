using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level6purple2 : MonoBehaviour {

	public GameObject Door;
	public bool doorIsOpening;


	void Update(){
		if (doorIsOpening == true) {
			Door.transform.Translate (Vector3.right * Time.deltaTime * 3);


		}
	}










	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "purpleball")
			
			doorIsOpening = true;





	}
}











