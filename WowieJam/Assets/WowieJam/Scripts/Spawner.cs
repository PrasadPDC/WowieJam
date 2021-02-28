using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Car;   
    public float timeInterval= 1f;
    public float timebetnspawn;

    public Transform[] SpawnPositon;
    // Start is called before the first frame update
    void Start()
    {        
        //SpawnPositon = GameObject.FindGameObjectsWithTag("SpawnPosition"); 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        timebetnspawn += 1;
        if (timebetnspawn >= timeInterval)
        {
            Instantiate(Car, SpawnPositon[Random.Range(0, SpawnPositon.Length)]);
            timebetnspawn = 0;
        }
     
    }
}
