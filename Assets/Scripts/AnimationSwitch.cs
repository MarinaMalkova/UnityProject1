using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour, ISwitch
{
    [SerializeField] private string OnTrigger = "On";
    [SerializeField] private string OffTrigger = "Off";

    private bool isOn = false;
    private Animator animator = null;
    
    
    void Start() => animator = GetComponent<Animator>();


    public bool IsOn() => isOn;

    public void SetOn(bool status)
    {
        isOn = status;
        animator.SetTrigger(status ? OnTrigger : OffTrigger);
    }
}
