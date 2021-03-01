using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Rigidbody rb;
    Vector3 move;
    [SerializeField] private float MoveSpeed;
    public bool isrun = true;
    private AudioManager audios;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1f;
        isrun = true;
        audios = GameObject.FindObjectOfType<AudioManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isrun)
        {
            move.x = Input.GetAxis("Horizontal");
            //move.y = Input.GetAxis("Vertical");
            move = (transform.right * move.x + transform.forward);

            rb.MovePosition(transform.position + move * MoveSpeed * Time.deltaTime);
        }
        else return;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            audios.Play("Win");
            Invoke("waitime", 0.2f);
            GetComponent<BoxCollider>().enabled = false;
        }

    }
    public void waitime()
    {
        isrun = false;
    }

}
