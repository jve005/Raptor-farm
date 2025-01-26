using System;
using System.ComponentModel;
using System.Linq;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    private DBManager dbManager;
    private RaptorManager raptorManager;
    public ContainerManager containerManager;
    
    public int money;
    public TMP_Text moneyText;

    private void Start()
    {
        dbManager = GetComponent<DBManager>();
        raptorManager = GetComponent<RaptorManager>();
        
        money = dbManager.InitializeMoney();
    }

    private void Update()
    {
        moneyText.text = money.ToString();
    }

    public void SellRaptor()
    {
        int index = containerManager.currentlySelected;
        raptorManager.raptorContainers[index].SetActive(false);
        
        dbManager.GetMoney(10);
        money += 10;
    }
}
