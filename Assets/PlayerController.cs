using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	//Rigidbodyで力を受ける
	private Rigidbody myRigidbody;
	//前進するための力
	private float fForce = 1.0f;

	//上下左右に移動する力
	private float mForce = 1.0f;
	//上下の移動できる範囲
	private float udRange = 6.4f;
	//左右の移動できる範囲
	private float lrRange = 8.4f;

	private float countTime = 0;
	private float EnemyBossMidTime = 3.0f;

	// Use this for initialization
	void Start () {
		//Rigidbodyコンポーネントを取得
		this.myRigidbody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {
		//Playerに前進する力を加える
		this.countTime += Time.deltaTime;
		if(this.countTime >= this.EnemyBossMidTime){
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
		} else{
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + this.fForce);
		}
		GameObject bossMid = GameObject.Find("EnemyBossMidPrefab(Clone)") as GameObject;
		if( bossMid != null ) {
			Debug.Log("iru");
		}else{
			Debug.Log("inai");
		}

		if(Input.GetKey(KeyCode.LeftArrow) && -this.lrRange < this.transform.position.x){
			this.transform.position = new Vector3(this.transform.position.x - this.mForce, this.transform.position.y, this.transform.position.z);
		} else if(Input.GetKey(KeyCode.RightArrow) && this.transform.position.x < this.lrRange){
			this.transform.position = new Vector3(this.transform.position.x + this.mForce, this.transform.position.y, this.transform.position.z);
		} else if(Input.GetKey(KeyCode.UpArrow)){
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + this.mForce, this.transform.position.z);
		} else if(Input.GetKey(KeyCode.DownArrow)){
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - this.mForce, this.transform.position.z);
		} 
		
	}
}
