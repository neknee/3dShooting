using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
	public GameObject bulletPrefab;

	private GameObject player;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		this.player = GameObject.Find("Player");

		if(Input.GetKey(KeyCode.Space)){
			GameObject bullet = Instantiate (bulletPrefab) as GameObject;
			bullet.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z);
		}
	}
}
