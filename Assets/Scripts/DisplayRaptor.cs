using System;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using Unity.VisualScripting;

public class DisplayRaptor : MonoBehaviour
{
    public int id;
    
    public GameManager gameManager;
    public ContainerManager containerManager;
    public RaptorGeneration raptorGeneration;

    public Image RaptorHead;
    public Image RaptorTorso;
    public Image RaptorTail;

    public TMP_Text RaptorName;
    public TMP_Text RaptorHunger;

    private void Start()
    {
        id = int.Parse(gameObject.name.Replace("Container", ""));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            CreateRaptor();
        }
    }

    public void InstansiateRaptor(Raptor raptor)
    {
        gameManager.GenerateRaptor(raptor, id);
    }

    public void CreateRaptor()
    {
        Raptor newRaptor = new Raptor();
        InstansiateRaptor(newRaptor);
        
        
        
        RaptorHead.sprite = newRaptor.Head;
        RaptorTorso.sprite = newRaptor.Torso;
        RaptorTail.sprite = newRaptor.Tail;

        RaptorName.text = newRaptor.Name;
        RaptorHunger.text = newRaptor.Hunger.ToString();
    }
}
