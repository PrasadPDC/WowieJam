using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 playerpos;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(playerpos.x, playerpos.y, player.transform.position.z + playerpos.z);
    }
}
