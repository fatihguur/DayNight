using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pembekutuyansima : MonoBehaviour {


	public bool pembeolayi = false;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "pembekutu")
			pembeolayi = true;
	}
}

