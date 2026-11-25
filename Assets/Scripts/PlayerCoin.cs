using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private int collectedCoins;
    public event Action<int> OnCoinAdd;
    public event Action<int> OnCoinInit;
    private void Start()
    {
        OnCoinInit?.Invoke(collectedCoins);
    }
    public void AddCoin(int coinToAdd)

    {
        collectedCoins += coinToAdd;
        OnCoinAdd?.Invoke(collectedCoins);
    }
}
