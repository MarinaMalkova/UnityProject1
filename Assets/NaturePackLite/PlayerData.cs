using System;
using UnityEngine;

public class PlayerData : MonoBehaviour { 

    public void Start()
    {
        UpdateCoins?.Invoke(coins);
        UpdateHearts?.Invoke(hp, maxHP);
    }
    public Action<int> UpdateCoins;
    [SerializeField] private int coins = 0;
    public void AddCoins(int value)
    {
        coins += value;
        UpdateCoins?.Invoke(coins);
    }
    public Action<int, int> UpdateHearts;
    [SerializeField] private int hp = 0;
    [SerializeField] private int maxHP = 0;
    public void AddHearts(int value)
    {
        hp += value;
        if (hp > maxHP)
            hp = maxHP;

        UpdateHearts?.Invoke(hp, maxHP);
    }
}
