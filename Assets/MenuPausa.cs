using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuPausa : MonoBehaviour
{
    [Header("Input Actions Pause")]
    [SerializeField] InputActionReference pause;
    [SerializeField] GameObject pauseScreen;


    bool pauseState = false;


    void OnEnable()
    {
        pause.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.action.WasPressedThisFrame() && !pauseState)
        {
            Debug.Log("saltando");
            pauseScreen.SetActive(true);
            Time.timeScale = 0f;
            pauseState = true;
        }
        else if(pause.action.WasPerformedThisFrame() && pauseState)
        {
            pauseScreen.SetActive(false);
            pauseState = false;
            Time.timeScale = 1f;
        }
    }

    void OnDisable()
    {
        pause.action.Disable();
    }
}
