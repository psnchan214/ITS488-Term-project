﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaveSpawner : MonoBehaviour {
	public static int EnemiesAlive = 0;

	public Wave[] waves;

	public Transform enemyPrefab;
	public Transform spawnPoint;

	public float timeBetweenWaves = 2f;
	private float countdown = 3f;

	private int waveIndex = 0;
	public TextMesh countText;

	public Gamemaneger gameManager;

	void Update ()
	{
		if(EnemiesAlive > 0){

			return;

		}
		if (waveIndex == waves.Length) {

			gameManager.WinLevel();
			this.enabled = false;

		}


		if (countdown <= 0f) {
			StartCoroutine (SpawnWave());
			countdown = timeBetweenWaves;
			return;
		}

		countdown -= Time.deltaTime;
		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		countText.text = string.Format("{0:00}", countdown);




	}

	IEnumerator SpawnWave ()
	{
		
		Playertstue.Rounds++;
		Wave wave = waves[waveIndex];
		for(int i =0; i < wave.count; i++)
		{
			
			SpawnEnemy(wave.enemy);
			yield return new WaitForSeconds (1f/ wave.rate);
		}
		waveIndex++;

	}

	void SpawnEnemy(GameObject enemy)
	{

		Instantiate (enemy, spawnPoint.position, spawnPoint.rotation);

		EnemiesAlive++;
	}



}


