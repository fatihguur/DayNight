using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel3 : MonoBehaviour {





	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (GameObject.Find("Blue_door").GetComponent<stay1>().player1_exit == false    && GameObject.Find("Red_door").GetComponent<stay2>().player2_exit == false)
		{
			SceneManager.LoadScene ("level4");
		}

	}
}
