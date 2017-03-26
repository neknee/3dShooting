using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	//Playerちゃんのオブジェクト
	private GameObject player;
	//Playerちゃんとカメラの距離
	private float distance;

	// Use this for initialization
	void Start () {
		//Playerオブジェクトを取得
		this.player = GameObject.Find("Player");
		//Playerとカメラの位置の差を求める
		this.distance = player.transform.position.z - this. transform.position.z;
		
	}
	
	// Update is called once per frame
	void Update () {
		//Playerの位置に合わせてカメラの位置を移動
		this.transform.position = new Vector3(0, this.transform.position.y, this.player.transform.position.z - distance);		
	}
}
