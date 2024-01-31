using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay1 : MonoBehaviour {

	public bool player1_exit=true;

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player1") {
			player1_exit = false;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player1") {
			player1_exit = true;
		}
	}



		


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
