using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public enum Death {Reload, Destroy};
    public Death deathType = Death.Destroy;
    public int HP = 10;
    public Action<int> onChange = null;
    private void Start()
    {
        onChange?.Invoke(HP);
    }

    public void TakeDamage(int power)
    {
        if (power >= HP)
        {
            switch (deathType)
            {
                case Death.Reload: SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    break;
                case Death.Destroy: Destroy(gameObject);
                    break;
            }
        }
        else
        {
            HP -= power;
            onChange?.Invoke(HP);
        }
    }
}