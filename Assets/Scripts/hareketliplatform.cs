using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketliplatform : MonoBehaviour {

	public GameObject platform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		platform.transform.Translate (-Vector3.right * Time.deltaTime * 3);
		
	}
}
