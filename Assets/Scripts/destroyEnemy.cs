using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyEnemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("choque con enemigo");

        if (CompareTag("UnArmedDroid"))
        {
            Debug.Log("enemy destro");
        }
    }
}
