﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject[] prefabList = new GameObject[2];
    public int spawnOrbit = 14;
    public float timeBetweenSpawn;

    private GameObject centerObject;
    private float radius;
    private Vector3 desiredPosition;

	// Use this for initialization
	void Start () {
        radius = OrbitGrid.orbitDistance * spawnOrbit;
        centerObject = GameObject.FindGameObjectWithTag("BlackHole");
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            desiredPosition = (new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0)).normalized * radius + centerObject.transform.position;
            Instantiate(prefabList[Random.Range(0, prefabList.Length)], desiredPosition, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}