using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground2 : MonoBehaviour {

	public Sprite spriteDay;
	public Sprite spriteNight;
	static bool gravity_switch2=true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("l"))
		{
			gravity_switch2 = !gravity_switch2;

		if (gravity_switch2)
			GetComponent<SpriteRenderer> ().sprite = spriteDay;
		if (!gravity_switch2)
			GetComponent<SpriteRenderer> ().sprite = spriteNight;
		
	}
}

}
