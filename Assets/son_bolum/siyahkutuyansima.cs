using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siyahkutuyansima : MonoBehaviour {


	public bool siyaholayi = false;

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "siyahkutu")
			siyaholayi = true;
	}
}

