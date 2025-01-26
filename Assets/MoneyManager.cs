using System;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    private DBManager dbManager;
    
    public int money;
    public TMP_Text moneyText;

    private void Start()
    {
        dbManager = GetComponent<DBManager>();
        
        money = dbManager.InitializeMoney();
    }

    private void Update()
    {
        moneyText.text = money.ToString();
    }

    public void SellRaptor(int index)
    {
        
    }
}
