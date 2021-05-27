using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlenderSpeed : MonoBehaviour
{

    public float spawnDelay = 0.85f;

    public GameObject BlenderPrefab;

    private float nextTimeToSpawn;


    // Update is called once per frame
    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {

            SpawnerBlender();

            nextTimeToSpawn = Time.time + spawnDelay;

        }

    }

    void SpawnerBlender()
    {
        Instantiate(BlenderPrefab, transform.position, transform.rotation);
    }
}// class