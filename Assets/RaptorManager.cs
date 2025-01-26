using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class RaptorManager : MonoBehaviour
{
    public GameObject[] raptorContainers;

    private int i = 0;

    private void Start()
    {
        i = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeRaptor();
        }
    }

    public void InitializeRaptor()
    {
        for (int i = 0; i < raptorContainers.Length; i++)
        {
            if (raptorContainers[i].activeSelf)
            {
                
            }
            else
            {
                raptorContainers[i].SetActive(true);
                break;
            }
        }
    }
}
