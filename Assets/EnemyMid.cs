using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMid : MonoBehaviour {
	public int damageMid = 3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (damageMid <= 0) {
            Destroy (this.gameObject);
        }
	}
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "bulletTag") {
			this.damageMid -= 1;
		}
	}
}
