using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestZombie : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Animator>().SetTrigger("dead");

    }
    void OnTriggerEnter(Collider other)
    {
        GetComponent<Animator>().SetTrigger("dead");
        /*Destroy(other.gameObject);*/
    }
}
