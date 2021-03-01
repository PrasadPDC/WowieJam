using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flickering : MonoBehaviour
{

  public GameObject i1;
    public GameObject i2;
    float nextFlicker;
    float FlickerDuration;

    // Start is called before the first frame update
    void Start()
    {
        nextFlicker = Random.Range(0.1f, 1f);
        FlickerDuration = nextFlicker + Random.Range(0.5f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (nextFlicker <= Time.time) Flicker();
        if (FlickerDuration <= Time.time) StopFlicker();
    }

    void Flicker()
    {
      i1.SetActive(false);
        i2.SetActive(false);
        nextFlicker = Time.time + Random.Range(0.5f, 1f);
    }

    void StopFlicker()
    {
      i1.SetActive(true);
        i2.SetActive(true);
        FlickerDuration = nextFlicker + Random.Range(0.1f, 1f);
    }

}
