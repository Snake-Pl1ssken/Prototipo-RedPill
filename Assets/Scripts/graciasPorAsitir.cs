using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class graciasPorAsitir : MonoBehaviour
{
    [SerializeField] GameObject canvasGraciasPorAsistir;
    //float tiempoPasado;
    //bool jugadorTocaTrigger = false;
    //private void Update()
    //{
    //    if (jugadorTocaTrigger)
    //    { 
    //        tiempoPasado += Time.deltaTime;
    //        if (tiempoPasado >= 30f)
    //        {
    //            SceneManager.LoadScene("Main_Menu");
    //        }
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvasGraciasPorAsistir.SetActive(true);
            //jugadorTocaTrigger = true;
        }

    }
}
