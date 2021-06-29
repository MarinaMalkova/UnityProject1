using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        if (GameObject.FindWithTag("Player").TryGetComponent(out Health hp))
        {
            hp.onChange += delegate (int health)
            {
                text.text = health.ToString();
            };
        }
    }
}
