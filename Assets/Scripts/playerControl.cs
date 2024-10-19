using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;

public class playerControl : MonoBehaviour
{
    [Header("Speeds")]
    [SerializeField] float baseSpeed = 2f;
    [SerializeField] float sprintSpeed = 4f;
    [Space(20)]
    [SerializeField] int jumpSpeed;

    [Header("Input Actions")]
    [SerializeField] InputActionReference jump;
    [SerializeField] InputActionReference sprint;

    CharacterController characterController;


    float currentSpeed = 2f;
    float verticalVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    void OnEnable()
    {
        jump.action.Enable();
        sprint.action.Enable();
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    //const float slopeVerticalVelocity = -2.5f;

    const float gravity = -15.81f;

    //private float sprintSpeed = 2f;

    void Update()
    {
        //verticalVelocity = 0;


        if (jump.action.WasPressedThisFrame() && characterController.isGrounded)
        {
            Debug.Log("saltando");
            verticalVelocity = jumpSpeed;
        }
        else if (sprint.action.IsPressed() && characterController.isGrounded)
        {
            Debug.Log("Mas Rapido Pressed");
            currentSpeed = sprintSpeed;
        }
        else if (!sprint.action.IsPressed() && characterController.isGrounded)
        {
            Debug.Log("Mas Rapido NotPressed");
            currentSpeed = baseSpeed;
        }

        verticalVelocity += gravity * Time.deltaTime;
        characterController.Move((new Vector3(-2f, 0f, 0f) * currentSpeed + Vector3.up * verticalVelocity) * Time.deltaTime);
        
    }

    void OnDisable()
    {
        jump.action.Disable();
        sprint.action.Disable();
    }
}


//Is (query)
//On (event)