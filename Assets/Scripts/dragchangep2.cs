using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragchangep2 : MonoBehaviour {

	static bool gravity_switch1=true;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	 if (Input.GetKeyDown("l"))
		{
			gravity_switch1 = !gravity_switch1;

			if (!gravity_switch1) {
				GameObject.Find ("Player2").GetComponent<Rigidbody2D> ().mass = 0.65f;
			}

			if(gravity_switch1) {
				GameObject.Find ("Player2").GetComponent<Rigidbody2D> ().mass = 1;


			}
		}
	}
}
