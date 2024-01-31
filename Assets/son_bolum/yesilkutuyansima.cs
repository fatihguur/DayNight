using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yesilkutuyansima : MonoBehaviour {


	public bool yesilolayi = false;
		
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "yesilkutu")
			yesilolayi = true;
		}
	}

