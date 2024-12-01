using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitPlayer : MonoBehaviour
{
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.CompareTag("Player"))
    //    {
    //        //Debug.Log("Chocando con player");
    //        MenuPausa.instance.PerderVida();
    //        Destroy(this.gameObject);
    //    }
    //}
    private bool playerHited = false;
    int vidasPlayer;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !playerHited)
        {
            //Debug.Log("Chocando con player");
            playerHited = true;
            //if (playerHited)
            //{
                //Debug.Log(playerHited);
                //playerHited = false;
                MenuPausa.instance.PerderVida();
            //    vidasPlayer++;
            //   Debug.Log(vidasPlayer);
            //}
            //else
            //{ 
                Destroy(this.gameObject);
            //}

        }
    }
}
