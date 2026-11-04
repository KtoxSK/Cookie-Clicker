using UnityEngine;
using TMPro;

public class Upgrade : MonoBehaviour
{
    public TextMeshProUGUI priceText;
    public TextMeshProUGUI levelText;

    public int level = 0;
    public int price = 10;

    public bool isAutoClicker = false;
    public AutoCookie autoCookie;

    public void BuyUpgrade()
    {
        if (Var.score >= price)
        {
            Var.score -= price;

            level++;

            if (isAutoClicker)
            {
                autoCookie.cookiesPerSecond++;
                autoCookie.ActivateAutoCookie();
            }
            else
            {
                Var.scorePerClick++;
            }

            price *= 2;

            UpdateUI();
            The.gameUI.UpdateScore();
        }
    }

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        priceText.text = "Price: " + price;
        levelText.text = "Level " + level;
    }
}