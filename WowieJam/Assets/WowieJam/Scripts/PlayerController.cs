using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Rigidbody rb;
    Vector3 move;
    [SerializeField] private float MoveSpeed;
  
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxis("Horizontal"); 
        //move.y = Input.GetAxis("Vertical");
        move = (transform.right * move.x + transform.forward );

        rb.MovePosition(transform.position + move * MoveSpeed * Time.deltaTime);
    }

  
   
}
