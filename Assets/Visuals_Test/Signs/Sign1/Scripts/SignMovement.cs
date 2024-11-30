using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SignMovement : MonoBehaviour
{
    [SerializeField] private float endPosition;
    [SerializeField] private float duration;

    [SerializeField] private Transform platform;


    // Update is called once per frame
    private void Start()
    {
        platform.DOMoveY(endPosition, duration).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }
}
