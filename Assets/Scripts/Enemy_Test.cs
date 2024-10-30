using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Test : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Chocando con player");
            MenuPausa.instance.PerderVida();
        }
    }

}
