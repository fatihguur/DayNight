using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mavikutuyansima : MonoBehaviour {


	public bool maviolayi = false;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "mavikutu")
			maviolayi = true;
	}
}

