using System;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayRaptor : MonoBehaviour
{
    public Raptor raptor;
    public GameManager gameManager;

    public Image RaptorHead;
    public Image RaptorTorso;
    public Image RaptorTail;

    public TMP_Text RaptorName;
    public TMP_Text RaptorHunger;

    private void Start()
    {
        raptor = new Raptor();
        gameManager.GenerateRaptor(raptor);
        
        RaptorHead.sprite = raptor.Head;
        RaptorTorso.sprite = raptor.Torso;
        RaptorTail.sprite = raptor.Tail;
        
        RaptorName.text = raptor.Name;
        RaptorHunger.text = raptor.Hunger.ToString();
    }
}
