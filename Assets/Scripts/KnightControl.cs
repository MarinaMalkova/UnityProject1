using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightControl : MonoBehaviour
{
    private Animator _animator;
    private Chase _chaseComponent;
    void Start()
    {
        _animator = GetComponent<Animator>();
        _chaseComponent = GetComponent<Chase>();
    }

    public void ChasePlayer()
    {
        _animator.SetBool("IsWalking", true);
        _chaseComponent.Begin(GameObject.FindWithTag("Player").transform);
    }

    
    public void ChaseStop()
    {
        _animator.SetBool("IsWalking", false);
        _chaseComponent.Stop();
    }
}
