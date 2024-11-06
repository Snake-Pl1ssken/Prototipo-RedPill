using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class AmmoShoot : MonoBehaviour
{ 

    [Header("Input Actions")]
    [SerializeField] Transform AmmoPosition;
    [SerializeField] InputActionReference shoot;
    [SerializeField] GameObject AmmoPrefab;
    [SerializeField] float speed;

    public float gunRange = 50f;
    public float fireRate = 0.2f;
    //public float laserDuration = 0.05f;
    private float fireTimer;

    void OnEnable()
    {
        shoot.action.Enable();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("UnArmedDroid"))
        {
            Debug.Log("choque con enemigo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer += Time.deltaTime;
        //&& fireTimer > fireRate
        if (shoot.action.WasPressedThisFrame())
        {
                
            GameObject Newammo = Instantiate(AmmoPrefab, AmmoPosition.position, AmmoPosition.transform.rotation);    
            
            Rigidbody rb = Newammo.GetComponent<Rigidbody>();
            rb.velocity = AmmoPosition.transform.forward * speed;
            if (CompareTag("UnArmedDroid"))
            {
                Debug.Log("choque con enemigo");
            }

        }
    }

    void OnDisable()
    {
        shoot.action.Disable();
    }
}