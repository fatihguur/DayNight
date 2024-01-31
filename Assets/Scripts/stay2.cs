using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay2 : MonoBehaviour {

	public bool player2_exit=true;

	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player2") {
			player2_exit = false;
		}
	}


	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player2") {
			player2_exit = true;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
