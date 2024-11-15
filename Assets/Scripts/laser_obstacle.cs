//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.InputSystem;
//using UnityEngine.InputSystem.XR;

//public class laser_obstacle : MonoBehaviour
//{
//    [Header("Laser Origin")]
//    [SerializeField] Transform laserSpawn;

//    public Camera playerCamera;
//    public float fireRate = 0.2f;
//    public float laserDuration = 0.05f;

//    LineRenderer laserLine1;
//    float fireTime;

//    void Awake()
//    {
//        laserLine1 = GetComponent<LineRenderer>();
//    }
//    void Update()
//    {
//        fireTime += Time.deltaTime;

//        fireTime = 0;
//        laserLine1.SetPosition(0, laserSpawn.position);
//        RaycastHit hit;
//        if (Physics.Raycast(laserSpawn.position, laserSpawn.up, out hit))
//        {
//            laserLine1.SetPosition(1, hit.point);
//            Destroy(hit.transform.gameObject);
//        }
//        StartCoroutine(ShootLaser());

//    }
//    IEnumerator ShootLaser()
//    {
//        laserLine1.enabled = true;
//        yield return new WaitForSeconds(laserDuration);
//        laserLine1.enabled = false;
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_obstacle : MonoBehaviour
{
    RaycastHit hit;
    public LineRenderer Linea;
    public Transform tr;
    private float largoDelLaser = 5f;
    private float anchoDelCollider = 1.1f;
    string tag = "Player";
    bool playerHit = false;

    private void Update()
    {
        Linea.SetPosition(0, (Vector3)tr.position + (Vector3)tr.up * (anchoDelCollider / 2));
        Linea.SetPosition(1, (Vector3)tr.position + (Vector3)tr.up * (largoDelLaser));

        if(Physics.Raycast(tr.position, Vector3.up, out hit, largoDelLaser))
        {
            if (hit.transform.gameObject.tag == tag)
            {
                if (!playerHit)
                {
                    playerHit = true;
                    //Debug.Log("Choque con player");
                    quitarVida();
                }

            }
        }
    }

    void quitarVida()
    {
        MenuPausa.instance.PerderVida();
    }
}