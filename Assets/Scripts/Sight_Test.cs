using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.UI.Image;

public class Sight_Test : MonoBehaviour
{
    [SerializeField] Transform EnemyGunPosition;
    [SerializeField] float maxDistance;
    //private bool hasLineOfSight = false;

    //private float GunPosition;

    private void Start()
    {
        EnemyGunPosition = gameObject.transform;
    }


    private void FixedUpdate()
    {
        RaycastHit hitRay;

        if (Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out hitRay, maxDistance))
        {
            Debug.Log("hit" + hitRay.transform.gameObject.name);
            Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green);

        }
        //Debug.Log(EnemyGunPosition.position);
    }

}
