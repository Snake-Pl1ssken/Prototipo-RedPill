using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using static UnityEngine.UI.Image;

public class Sight_Test : MonoBehaviour
{
    [SerializeField] Transform EnemyGunPosition;
    [SerializeField] GameObject mePatrolEnemy;
    [SerializeField] float maxDistance;
    [SerializeField] float speed;
    bool iSeetheEnemy = false;
    float timePassed;

    private void Start()
    {
        EnemyGunPosition = gameObject.transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MenuPausa.instance.PerderVida();
        }
    }

    private void Update()
    {
        if (iSeetheEnemy)
        {
            timePassed += Time.deltaTime;
            if (timePassed >= 3f)
            { 
                Debug.Log("Me destruyo");
                Destroy(mePatrolEnemy);
            }
        }
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out RaycastHit hitRay, maxDistance))
        {
            Debug.Log("hit" + hitRay.transform.gameObject.name);
            Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green); //Solo Scene
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity = transform.forward * speed;
            iSeetheEnemy = true;
     //       Debug.Log("iSeetheEnemy a TRUE");
        }
    }

}
