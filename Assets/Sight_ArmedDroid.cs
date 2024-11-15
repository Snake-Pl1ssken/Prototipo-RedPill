using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight_ArmedDroid : MonoBehaviour
{
    [SerializeField] Transform EnemyGunPosition;
    [SerializeField] float maxDistance;
    [SerializeField] Animator animator;
    //[SerializeField] float speed;
    bool startShoot;

    private void Start()
    {
        EnemyGunPosition = gameObject.transform;
        animator = GetComponent<Animator>();
        startShoot = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MenuPausa.instance.PerderVida();
        }
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out RaycastHit hitRay, maxDistance))
        {
            //Debug.Log("hit" + hitRay.transform.gameObject.name);
            Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green); //Solo Scene
            //Rigidbody rb = GetComponent<Rigidbody>();
            //rb.velocity = transform.forward * speed;
            startShoot = true;
        }
        if (startShoot) 
        {
            Debug.Log("iniciar animacion");
            animator.SetBool("seePlayer", true);
            startShoot = false;
        }
        else if (!startShoot)
        {
            Debug.Log("Fin animacion");
            animator.SetBool("seePlayer", false);
        }
    }

}
