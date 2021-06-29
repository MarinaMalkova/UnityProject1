using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwim : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player") && other.TryGetComponent(out Animator animator))
        {
            animator.SetBool("Swimming", true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && other.TryGetComponent(out Animator animator))
        {
            animator.SetBool("Swimming", false);
        }
    }
}
