using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButtons : MonoBehaviour
{
    private AudioSource SFXButtons;
    [SerializeField] AudioClip clickAudio;
    [SerializeField] AudioClip hoverAudio;
    
    // Start is called before the first frame update
    void Start()
    {
        SFXButtons = GetComponent<AudioSource>();
    }

    public void ClickAudioOn()
    { 
        SFXButtons.PlayOneShot(clickAudio);
    }

    public void HoverAudioOn()
    {
        SFXButtons.PlayOneShot(hoverAudio);
    }
}
