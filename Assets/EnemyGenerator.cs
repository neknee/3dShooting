using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyGenerator : MonoBehaviour {
	//Enemy
	public GameObject EnemyPrefab;
	public GameObject EnemyBossMidPrefab;
	public GameObject EnemyBossPrefab;
	private float enemyRange = 5.5f;

	//UI
	private GameObject gameOverText;
	private GameObject lapsedTimeText;
	private float countTime = 0;
	private float EnemyBossMidTime = 3.0f;
	private bool one = true;
	private bool isEnemy = false;
	private bool isEnemyMidBoss = false;
	private bool isEnemyBoss = false;
	private bool isGameOver = false;

	private GameObject player;
	private GameObject enemyMids;

	// Use this for initialization
	void Start () {
		this.lapsedTimeText = GameObject.Find("LapsedTime");
		this.gameOverText = GameObject.Find("GameOver");
		this.player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		this.countTime += Time.deltaTime;
		this.lapsedTimeText.GetComponent<Text>().text = "Time: " + countTime.ToString("F2") + "ms";


		if(this.countTime >= this.EnemyBossMidTime){
			if(one){
				EnemyMidGen();
				one = false;
				this.isEnemy = false;

				if(GameObject.Find("EnemyBossMidPrefab").GetComponent<EnemyMid>().damageMid == 3){
					Debug.Log("work");
					Destroy(gameObject);
				}
			}
		} else {
			EnemyGen();
		}
	}
	public void EnemyGen(){
		int pos = Random.Range(-100,100);
		GameObject Enemy = Instantiate (EnemyPrefab) as GameObject;
		Enemy.transform.position = new Vector3 (player.transform.position.x * pos, player.transform.position.y * pos, player.transform.position.z + 100);
		this.isEnemy = true;
	}
	public void EnemyMidGen(){
		GameObject EnemyBossMid = Instantiate (EnemyBossMidPrefab) as GameObject;
		EnemyBossMid.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z + 30);
		this.isEnemyMidBoss = true;
	}
	public void EnemyBossGen(){
		GameObject EnemyBoss = Instantiate (EnemyBossPrefab) as GameObject;
		EnemyBoss.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, player.transform.position.z + 30);
		this.isEnemyBoss = true;
	}
	public void GameOver(){
		this.gameOverText.GetComponent<Text>().text = "GameOver";
		this.isGameOver = true;
	}
}
