using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Car;
    public GameObject[] SpawnPositon;
    // Start is called before the first frame update
    void Start()
    {        
        SpawnPositon = GameObject.FindGameObjectsWithTag("SpawnPosition");
    }

    // Update is called once per frame
    void Update()
    {
        GameObject spawnObject = Instantiate(Car);
    }
}
