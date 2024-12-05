using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

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
    [Space(20)]
    [Header("Door movement")]
    [SerializeField] Transform right;
    [Space(20)]
    [Header("Canvas Group")]
    [SerializeField] CanvasGroup ExitSureCanvasGroup;
    //[SerializeField] CanvasGroup MainMenuCanvasGroup;
    [SerializeField] CanvasGroup CreditosCanvasGroup;
    [SerializeField] CanvasGroup OpcionesCanvasGroup;
    [SerializeField] CanvasGroup IniciarJuegoCanvasGroup;

    // Este método debe estar público para que lo puedas asignar al botón desde el inspector.
    public void Switch_Scene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }


    ////////////////////FUNCIONALIDAD INICIARJUEGO BUTTON////////////////////////////////////////
    public void IniciarJuego()
    {
        /////////////////////Fade///////////////////
        IniciarJuegoCanvasGroup.blocksRaycasts = true;
        IniciarJuegoCanvasGroup.interactable = true;
        IniciarJuegoCanvasGroup.DOFade(1f, 5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        /////////////////////Fade///////////////////
        IniciarJuegoCanvasGroup.blocksRaycasts = false;
        IniciarJuegoCanvasGroup.interactable = false;
        //IniciarJuegoCanvasGroup.alpha = 0f;
        //Debug.Log(IniciarJuegoCanvasGroup.alpha);
        IniciarJuegoCanvasGroup.DOFade(0f, 0.5f).SetEase(Ease.Linear);
        //IniciarJuegoCanvasGroup.DOFade(2f, 0.5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        /////////////////////Fade///////////////////
        OpcionesCanvasGroup.blocksRaycasts = true;
        OpcionesCanvasGroup.interactable = true;
        OpcionesCanvasGroup.DOFade(1f, 5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        /////////////////////Fade///////////////////
        OpcionesCanvasGroup.blocksRaycasts = false;
        OpcionesCanvasGroup.interactable = false;
        OpcionesCanvasGroup.DOFade(0f, 0.5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        /////////////////////Fade///////////////////
        CreditosCanvasGroup.blocksRaycasts = true;
        CreditosCanvasGroup.interactable = true;
        CreditosCanvasGroup.DOFade(1f, 5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        /////////////////////Fade///////////////////
        CreditosCanvasGroup.blocksRaycasts = false;
        CreditosCanvasGroup.interactable = false;
        CreditosCanvasGroup.DOFade(0f, 0.5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        //////////////Rotate_Door//////////////////
        right.DORotate(Vector3.up * 90f, 5f, RotateMode.FastBeyond360).SetRelative().SetEase(Ease.OutFlash);
        //////////////Rotate_Door//////////////////

        /////////////////////Fade///////////////////
        ExitSureCanvasGroup.blocksRaycasts = true;
        ExitSureCanvasGroup.interactable = true;
        ExitSureCanvasGroup.DOFade(1f, 5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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
        //////////////Rotate_Door//////////////////
        right.DORotate(Vector3.up * -90f, 3f, RotateMode.FastBeyond360).SetRelative().SetEase(Ease.OutFlash);
        //////////////Rotate_Door//////////////////

        /////////////////////Fade///////////////////
        ExitSureCanvasGroup.blocksRaycasts = false;
        ExitSureCanvasGroup.interactable = false;
        ExitSureCanvasGroup.DOFade(0f, 0.5f).SetEase(Ease.Linear);
        /////////////////////Fade///////////////////

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




    ////////////////////FUNCIONALIDAD SONIDO EN LOS BOTONES////////////////////////////////////////
    public void ClickAudioOn()
    {
        SFXButtons.PlayOneShot(clickAudio);
    }

    public void HoverAudioOn()
    {
        SFXButtons.PlayOneShot(hoverAudio);
    }
    ////////////////////FUNCIONALIDAD SONIDO EN LOS BOTONES////////////////////////////////////////
}
