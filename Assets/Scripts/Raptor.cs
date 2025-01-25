using UnityEngine;

[CreateAssetMenu(fileName = "New Raptor", menuName = "Raptor")]
public class Raptor : ScriptableObject
{
    public string Name;
    
    public int RaptorID;
    public int Hunger;
    public int Cooldown;

    public Sprite Head;
    public Sprite Torso;
    public Sprite Tail;
}
