using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sarikutuyansima : MonoBehaviour {


	public bool sariolayi = false;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "sarikutu")
			sariolayi = true;
	}
}

