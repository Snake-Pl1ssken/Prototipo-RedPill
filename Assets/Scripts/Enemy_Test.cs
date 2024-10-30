using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using static UnityEngine.UI.Image;

public class Enemy_Test : MonoBehaviour
{
    //[SerializeField] Transform EnemyGunPosition;
    //[SerializeField] float maxDistance;
    //private bool hasLineOfSight = false;
    
    //private float GunPosition;

    //private void Start()
    //{
    //    EnemyGunPosition = gameObject.transform;
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Chocando con player");
            MenuPausa.instance.PerderVida();
        }
    }

    //private void FixedUpdate()
    //{
    //    RaycastHit hitRay;
            
    //    if(Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out hitRay, maxDistance))
    //    {
    //        Debug.Log("hit" + hitRay.transform.gameObject.name);
    //        Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green);
    
    //    }
    //    //Debug.Log(EnemyGunPosition.position);
    //}

}
