using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

	public static AudioClip daySound, nightSound;
	static AudioSource audioSrc;
	static bool gravity_switch1=true;
	static bool gravity_switch2=true;
	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "daySound":
			audioSrc.PlayOneShot (daySound);
			break;
		case "nightSound":
			audioSrc.PlayOneShot (nightSound);
			break;
		}
	}

	// Use this for initialization
	void Start () {

		daySound = Resources.Load<AudioClip> ("daySound");
		nightSound = Resources.Load<AudioClip> ("nightSound");

		audioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("v")) {
			gravity_switch1 = !gravity_switch1;

			if (gravity_switch1)
				SoundManagerScript.PlaySound ("daySound");
			if (!gravity_switch1)
				SoundManagerScript.PlaySound ("nightSound");
		}
		{

			if (Input.GetKeyDown ("l")) {
				gravity_switch2 = !gravity_switch2;

				if (gravity_switch2)
					SoundManagerScript.PlaySound ("daySound");
				if (!gravity_switch2)
					SoundManagerScript.PlaySound ("nightSound");
			}
		
	}



}
}

