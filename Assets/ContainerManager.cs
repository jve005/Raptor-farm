using System;
using UnityEngine;

public class ContainerManager : MonoBehaviour
{
    public int currentlySelected;
    public bool[] isSelected;
    
    public GameObject[] containers;

    public void SelectContainer(int index)
    {
        for (int i = 0; i < isSelected.Length; i++)
        {
            isSelected[i] = false;
        }
        
        isSelected[index] = true;
        currentlySelected = index;
    }
}
