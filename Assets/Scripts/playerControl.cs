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
    [Space(20)]
    [SerializeField] InputActionReference jump;
    [SerializeField] InputActionReference sprint;

    CharacterController characterController;
    Animator anim;

    float currentSpeed = 2f;
    float verticalVelocity;
    public int saltosQuepuedoDarSeguidos = 2;
    private int numSaltosRestantes;

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        characterController = GetComponent<CharacterController>();
        numSaltosRestantes = saltosQuepuedoDarSeguidos;
    }

    void OnEnable()
    {
        jump.action.Enable();
        sprint.action.Enable();
    }

    const float gravity = -15.81f;

    void Update()
    {
        if (characterController.isGrounded)
        {
            numSaltosRestantes = saltosQuepuedoDarSeguidos;

        }
        if (jump.action.WasPressedThisFrame() && numSaltosRestantes > 0)
        {
            
            Debug.Log("saltando");
            numSaltosRestantes--;
            //if (numSaltos < 2)
            //{ 
            verticalVelocity = jumpSpeed;
            //}

        }
        else if (sprint.action.IsPressed() && characterController.isGrounded)
        {
            Debug.Log("Mas Rapido Pressed");
            currentSpeed = sprintSpeed;
        }
        else if (!sprint.action.IsPressed() && characterController.isGrounded)
        {
            currentSpeed = baseSpeed;
        }

        verticalVelocity += gravity * Time.deltaTime;
        characterController.Move((new Vector3(2f, 0f, 0f) * currentSpeed + Vector3.up * verticalVelocity) * Time.deltaTime);

        //animacion de salto
        anim.SetBool("Saltando", !characterController.isGrounded);

        if (!characterController.isGrounded)
        {
            float normalizedVSpeed = Mathf.InverseLerp(jumpSpeed, -jumpSpeed, verticalVelocity);
            anim.SetFloat("VSpeed", normalizedVSpeed);
        }
        else
        {
            anim.SetFloat("VSpeed", 1f);
        }

    }

    void OnDisable()
    {
        jump.action.Disable();
        sprint.action.Disable();
    }
}


//Is (query)
//On (event)