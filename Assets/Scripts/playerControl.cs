using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControl : MonoBehaviour
{
    [Header("Input Actions")]
    [SerializeField] InputActionReference move;
    [SerializeField] InputActionReference jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float velocidad = 2f;

    void Update()
    {
        transform.Translate(new Vector3(0f, 0f, 1f) * velocidad * Time.deltaTime);
    }
}


//Is (query)
//On (event)