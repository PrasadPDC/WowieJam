using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerpos;
    public GameObject[] Car;   
    public float timeInterval= 1f;
    public float timebetnspawn;

    public Transform[] SpawnPositon1;
    public Transform[] SpawnPositon2;
    // Start is called before the first frame update
    void Start()
    {        
      
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(playerpos.x, playerpos.y, player.transform.position.z + playerpos.z);
        timebetnspawn += Time.deltaTime;
        if (timebetnspawn >= timeInterval)
        {
            Instantiate(Car[Random.Range(0,Car.Length)], SpawnPositon1[Random.Range(0, SpawnPositon1.Length)]);
            Instantiate(Car[Random.Range(0, Car.Length)], SpawnPositon2[Random.Range(0, SpawnPositon2.Length)]);
            timebetnspawn = 0;
        }
     
    }

}
