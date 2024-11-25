using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Sight_ArmedDroid : MonoBehaviour
{
    [SerializeField] Transform EnemyGunPosition;
    [SerializeField] float maxDistance;
    [SerializeField] Animator animator;
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject lifeItem;
    [SerializeField] float speed;
    [SerializeField] Transform meAnEnemyArmed;
    BoxCollider myBody;
    Transform myBodyTransform;
    bool startShoot;

    private void Start()
    {
        DOTween.Init();
        animator = GetComponent<Animator>();
        myBody = GetComponent<BoxCollider>();
        myBodyTransform = meAnEnemyArmed;
        startShoot = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            MenuPausa.instance.PerderVida();
        }
        if (other.gameObject.CompareTag("PlayerBullet"))
        {

            myBody.enabled = false;
            animator.SetBool("IamALive", true);

        }
    }

    private void FixedUpdate()
    {
        if (Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out RaycastHit hitRay, maxDistance))
        {
            Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green); 
            startShoot = true;
        }
        if (startShoot) 
        {
            animator.SetBool("seePlayer", true);
            startShoot = false;
        }
        else if (!startShoot)
        {
            animator.SetBool("seePlayer", false);
        }
    }

    void shoot()
    {
        GameObject Newammo = Instantiate(bullet,EnemyGunPosition.position, EnemyGunPosition.rotation);
        Rigidbody rb = Newammo.GetComponent<Rigidbody>();
        rb.velocity = EnemyGunPosition.transform.forward * speed;
        if (CompareTag("Player"))
        {
            Debug.Log("choque con Player");
        }
    }

    void finalDeathAnimation()
    {    
        myBodyTransform.DOMoveY(-1.8f, 1f);
    }

    void destroyRobot()
    {
        Destroy(meAnEnemyArmed.gameObject);
    }

    void SpawnLife()
    {
        Instantiate(lifeItem, EnemyGunPosition.position, EnemyGunPosition.rotation);
    }

}
