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
    [SerializeField] AudioSource enemyInMySight;
    [SerializeField] AudioSource robotDeathSound;
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



    //private void FixedUpdate()
    //{
    //    // Define el ángulo de visión (en grados) y la cantidad de rayos
    //    float visionAngle = 90f; // Campo de visión en grados
    //    int rayCount = 10; // Número de rayos a lanzar para simular un cono
    //    bool playerDetected = false; // Variable para verificar si el jugador está en el cono

    //    // Iterar sobre un rango de ángulos desde -visionAngle/2 hasta +visionAngle/2
    //    for (int i = 0; i < rayCount; i++)
    //    {
    //        // Calcula el ángulo de cada rayo
    //        float angle = -visionAngle / 2 + (visionAngle / (rayCount - 1)) * i;
    //        Quaternion rotation = Quaternion.Euler(0, angle, 0);

    //        // Dirección del rayo
    //        Vector3 rayDirection = rotation * EnemyGunPosition.forward;

    //        // Lanzar el Raycast
    //        if (Physics.Raycast(EnemyGunPosition.position, rayDirection, out RaycastHit hit, maxDistance))
    //        {
    //            Debug.DrawRay(EnemyGunPosition.position, rayDirection * maxDistance, Color.green);

    //            if (hit.collider.CompareTag("Player"))
    //            {
    //                playerDetected = true; // El jugador está dentro del campo de visión
    //                break; // No necesitamos seguir verificando más rayos
    //            }
    //        }
    //        else
    //        {
    //            Debug.DrawRay(EnemyGunPosition.position, rayDirection * maxDistance, Color.red);
    //        }
    //    }

    //    // Actualizar la animación según la detección
    //    if (playerDetected)
    //    {
    //        animator.SetBool("seePlayer", true);
    //        startShoot = true;
    //    }
    //    else
    //    {
    //        animator.SetBool("seePlayer", false);
    //        startShoot = false;
    //    }
    //}


    private void FixedUpdate()
    {
        if (Physics.Raycast(EnemyGunPosition.position, EnemyGunPosition.forward, out RaycastHit hitRay, maxDistance))
        {
            Debug.DrawRay(EnemyGunPosition.position, EnemyGunPosition.forward * 10, Color.green);
            if (hitRay.collider.CompareTag("Player"))
            { 
                startShoot = true;
            }
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
    void EnemyInMySight()
    {
        enemyInMySight.Play();
    }
    void RobotDeathSoud()
    {
        enemyInMySight.Stop();
        robotDeathSound.Play();
    }
}
