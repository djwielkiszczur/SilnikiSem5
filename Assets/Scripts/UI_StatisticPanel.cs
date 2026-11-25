using TMPro;
using UnityEngine;

public class UI_StatisticPanel : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TextMeshProUGUI healthText;
    public PlayerCoin playerCoin;
    public TextMeshProUGUI coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        playerHealth.OnAddHealth += PlayerHealth_OnAddHealth;
        playerHealth.OnHealthInnit += PlayerHealth_OnHealthInnit;
        playerCoin.OnCoinAdd += PlayerCoin_OnCoinAdd;
        playerCoin.OnCoinInit += PlayerCoin_OnCoinInit;

    }

    private void PlayerCoin_OnCoinInit(int obj)
    {
       ModifyCoinText(obj);
    }

    private void PlayerCoin_OnCoinAdd(int obj)
    {
        ModifyCoinText(obj);
    }

    private void ModifyCoinText(int obj)
    {
       coinText.text = "Coins: " + obj.ToString();
    }

    private void PlayerHealth_OnHealthInnit(int health)
    {
        ModifyHealthText(health);
    }

    private void ModifyHealthText(int health)
    {
        healthText.text = health.ToString();
    }

    private void PlayerHealth_OnAddHealth(int health)
    {
       ModifyHealthText(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
