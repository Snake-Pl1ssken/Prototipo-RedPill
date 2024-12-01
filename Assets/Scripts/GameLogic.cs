using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    //[SerializeField] ;
    // Start is called before the first frame update
    [Header("VirtualCameras")]
    [SerializeField] CinemachineVirtualCamera MainMenu;
    [SerializeField] CinemachineVirtualCamera exit;
    [SerializeField] CinemachineVirtualCamera options;
    [SerializeField] CinemachineVirtualCamera play;
    [SerializeField] CinemachineVirtualCamera credits;
    [Space(20)]
    [Header("Canvas a cambiar")]
    [SerializeField] Canvas ExitSureCanvas;
    [SerializeField] Canvas MainMenuCanvas;
    [SerializeField] Canvas CreditosCanvas;
    [SerializeField] Canvas OpcionesCanvas;
    [SerializeField] Canvas IniciarJuegoCanvas;
    [Space(20)]
    [Header("Sonido")]
    [SerializeField] AudioSource SFXButtons;
    [SerializeField] AudioClip clickAudio;
    [SerializeField] AudioClip hoverAudio;

    // Update is called once per frame
    void Update()
    {

    }

    // Este método debe estar público para que lo puedas asignar al botón desde el inspector.
    public void Switch_Scene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }


    ////////////////////FUNCIONALIDAD INICIARJUEGO BUTTON////////////////////////////////////////
    public void IniciarJuego()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(true);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        MainMenuCanvas.gameObject.SetActive(false);
        ExitSureCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        IniciarJuegoCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    public void volverIniciarJuego()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        ExitSureCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        IniciarJuegoCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }
    ////////////////////FUNCIONALIDAD INICIARJUEGO BUTTON////////////////////////////////////////




    ////////////////////FUNCIONALIDAD OPCIONES BUTTON////////////////////////////////////////
    public void opciones()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        MainMenuCanvas.gameObject.SetActive(false);
        ExitSureCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    public void volverOpciones()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        ExitSureCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }
    ////////////////////FUNCIONALIDAD OPCIONES BUTTON////////////////////////////////////////








    ////////////////////FUNCIONALIDAD CREDITOS BUTTON////////////////////////////////////////
    public void creditos()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
        exit.gameObject.SetActive(false);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        MainMenuCanvas.gameObject.SetActive(false);
        ExitSureCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    public void volverCreditos()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        ExitSureCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    ////////////////////FUNCIONALIDAD CREDITOS BUTTON////////////////////////////////////////








    ////////////////////FUNCIONALIDAD EXIT BUTTON////////////////////////////////////////
    public void Exit()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(false);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(true);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        MainMenuCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive(false);
        CreditosCanvas.gameObject.SetActive(false);
        ExitSureCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    public void NO()
    {
        /////////////Camaras//////////////////
        MainMenu.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
        play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        /////////////Camaras//////////////////

        ////////////Canvas//////////////////
        ExitSureCanvas.gameObject.SetActive(false);
        OpcionesCanvas.gameObject.SetActive (false);
        CreditosCanvas.gameObject.SetActive(false);
        MainMenuCanvas.gameObject.SetActive(true);
        ////////////Canvas//////////////////
    }

    public void SI()
    {
        Application.Quit();
    }
    ////////////////////FUNCIONALIDAD EXIT BUTTON////////////////////////////////////////





    public void ClickAudioOn()
    {
        SFXButtons.PlayOneShot(clickAudio);
    }

    public void HoverAudioOn()
    {
        SFXButtons.PlayOneShot(hoverAudio);
    }




}
