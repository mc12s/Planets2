using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if(col.gameObject.CompareTag("bullet")){
			Destroy(col.gameObject);
		}
	}
}
