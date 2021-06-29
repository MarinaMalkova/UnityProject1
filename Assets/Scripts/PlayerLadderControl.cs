using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLadderControl : MonoBehaviour
{
    void Update()
    {
        if (player)
        {
            Vector3 direction = player.velocity;
            direction.z = Input.GetAxis("Vertical") * 10;
            direction.x = Input.GetAxis("Horizontal") * 10;
            player.velocity = direction;
        }
    }

    Rigidbody player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<Rigidbody>();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
        }
    }
}
