using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gamemanager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.back * speed * Time.deltaTime,ForceMode.Force);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collider"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Player"))
        {
            gamemanager.gameover = true;
        }
    }
}
