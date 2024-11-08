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
    private float fireTimer = 0.1f;
    //public float laserDuration = 0.05f;

    void OnEnable()
    {
        shoot.action.Enable();
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        if (shoot.action.WasPressedThisFrame() && fireTimer > fireRate)
        {
                
            GameObject Newammo = Instantiate(AmmoPrefab, AmmoPosition.position, AmmoPosition.transform.rotation);    
            
            Rigidbody rb = Newammo.GetComponent<Rigidbody>();
            rb.velocity = AmmoPosition.transform.forward * speed;
            Destroy(Newammo,1f);
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