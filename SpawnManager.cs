﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;
    //public int animalIndex;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",2,1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        //if (Input.GetKeyDown(KeyCode.S))
        //{
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(Random.Range(-15, 15), 0, 20), animalPrefabs[animalIndex].transform.rotation);
        //}
    }
}
