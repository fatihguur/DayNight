using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spike : MonoBehaviour {


	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2") {
			Destroy (col.gameObject);
			SceneManager.LoadScene ("level2");
		}
	}

		



		

	}


