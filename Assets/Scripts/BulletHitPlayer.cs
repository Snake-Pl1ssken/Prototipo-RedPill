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
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Chocando con player");
            MenuPausa.instance.PerderVida();
            Destroy(this.gameObject);
        }
    }
}
