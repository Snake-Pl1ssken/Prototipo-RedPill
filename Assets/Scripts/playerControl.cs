using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerControl : MonoBehaviour
{
    [Header("Input Actions")]
    [SerializeField] InputActionReference jump;
    [SerializeField] float jumpSpeed;

    CharacterController characterController;

    float verticalVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void OnEnable()
    {
        jump.action.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    //const float slopeVerticalVelocity = -2.5f;

    const float gravity = -15.81f;

    private float velocidad = 2f;

    void Update()
    {
        //verticalVelocity = 0;

        characterController.Move(new Vector3(-2f, 0f, 0f) * velocidad * Time.deltaTime);

        if (jump.action.WasPressedThisFrame())
        {
            Debug.Log("saltando");
            verticalVelocity = jumpSpeed;
        }
        verticalVelocity += gravity * Time.deltaTime;
        characterController.Move(Vector3.up * verticalVelocity * Time.deltaTime);
    }

    void OnDisable()
    {
        jump.action.Disable();
    }
}


//Is (query)
//On (event)