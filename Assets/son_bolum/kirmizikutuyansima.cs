using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirmizikutuyansima : MonoBehaviour {


	public bool kirmiziolayi = false;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "kirmizikutu")
			kirmiziolayi = true;
	}
}

