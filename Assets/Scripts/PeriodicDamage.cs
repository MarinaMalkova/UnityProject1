using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeriodicDamage : MonoBehaviour
{
    [SerializeField] float damageTime = 0.5f;
    [SerializeField] int power = 1;
    private Health playerHealth = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth = other.GetComponent<Health>();
            if (damageTime == 0)
            {
                DamagePlayer();
            }
            else
            {
                InvokeRepeating("DamagePlayer", 0, damageTime);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CancelInvoke();
        }
    }

    private void DamagePlayer() => playerHealth.TakeDamage(power);
}
