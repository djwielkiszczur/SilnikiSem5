using System;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private int coinsForMaxHealth = 10;
    private int collectedCoins;
    public event Action<int> OnCoinAdd;
    public event Action<int> OnCoinInit;
    private void Awake()
    {
        if (playerHealth == null)
        {
            playerHealth = GetComponent<PlayerHealth>();
        }
    }
    private void Start()
    {
        OnCoinInit?.Invoke(collectedCoins);
    }
    public void AddCoin(int coinToAdd)

    {
        collectedCoins += coinToAdd;
        if (collectedCoins >= coinsForMaxHealth)
        {
            collectedCoins = collectedCoins - coinsForMaxHealth;
            if (playerHealth != null) {
                playerHealth.AddHealth(playerHealth.maxHealth);
            }
            // else if (TryGetComponent<PlayerHealth>(out PlayerHealth healthComponent))
            // { player health = healthComponent; HealPlayerForCoins(); }
            else
            {
                Debug.Log("Health component is not in the same game object as Player Coin");
            }
        }
        OnCoinAdd?.Invoke(collectedCoins);
    }
}
