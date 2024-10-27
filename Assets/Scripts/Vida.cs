using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("RecuperandoVida");
            bool VidaRecuperada = MenuPausa.instance.RecuperarVida();

            if (VidaRecuperada)
            { 
                Destroy(this.gameObject);
            }
        }
    }
}
