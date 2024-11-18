using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("choque con enemigo");

        if (other.gameObject.CompareTag("UnArmedDroid"))
        {
            Debug.Log("enemy destroy");
        }
    }
}
