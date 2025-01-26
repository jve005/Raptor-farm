using System;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class DisplayRaptor : MonoBehaviour
{
    public int id;
    
    public ContainerManager containerManager;
    public RaptorGeneration raptorGeneration;
    
    public Image RaptorHead;
    public Image RaptorTorso;
    public Image RaptorTail;

    public TMP_Text RaptorName;
    public TMP_Text RaptorHunger;

    private void Start()
    {
        raptorGeneration.CreateRaptor();
        
        Raptor raptor = new Raptor();
        
        RaptorHead.sprite = raptor.Head;
        RaptorTorso.sprite = raptor.Torso;
        RaptorTail.sprite = raptor.Tail;
        
        RaptorName.text = raptor.Name;
        RaptorHunger.text = raptor.Hunger.ToString();
    }
}
