using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonhareket : MonoBehaviour {

	public GameObject hareketliplatform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void	OnCollisionStay2D(Collision2D col){

		if (col.gameObject.name == "Player1" || col.gameObject.name == "Player2") {
			hareketliplatform.transform.Translate (Vector3.right * Time.deltaTime * 3);
		
		}
		}
}
