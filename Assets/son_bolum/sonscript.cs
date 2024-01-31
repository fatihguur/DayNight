using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonscript : MonoBehaviour {

	public GameObject asagi1;
	public GameObject asagi2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("kirmizikutuyansima").GetComponent<kirmizikutuyansima> ().kirmiziolayi == true && GameObject.Find ("mavikutuyansima").GetComponent<mavikutuyansima> ().maviolayi == true && GameObject.Find ("pempekutuyansima").GetComponent<pembekutuyansima> ().pembeolayi == true && GameObject.Find ("sarikutuyansima").GetComponent<sarikutuyansima> ().sariolayi == true && GameObject.Find ("siyahkutuyansima").GetComponent<siyahkutuyansima> ().siyaholayi == true && GameObject.Find ("yesilkutuyansima").GetComponent<yesilkutuyansima> ().yesilolayi == true) 
		{	
			asagi1.transform.Translate(-Vector3.up * Time.deltaTime * 3);
			asagi2.transform.Translate(-Vector3.up * Time.deltaTime * 3);
		}
	}
}
