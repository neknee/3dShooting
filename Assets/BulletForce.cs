using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour {
	private GameObject player;

	private float fForce = 2.0f;

	private  float delta = 0;

	private  float span = 2.0f;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find("Player");
		this.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
		this.delta += Time.deltaTime;
		if ( this.delta > this.span ){
			Destroy (gameObject);
		}
		this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z + fForce);
	}
	void OnTriggerEnter(Collider other) {
		Destroy (gameObject);
	}
}
