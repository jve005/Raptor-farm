using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Raptor raptor;
    
    public Sprite[] heads;
    public Sprite[] torsos;
    public Sprite[] tails;
    
    public Raptor GenerateRaptor(Raptor newRaptor, int id)
    {
        var randRaptorName = RaptorNames.names[Random.Range(0, RaptorNames.names.Length)];
        newRaptor.Name = randRaptorName;
        newRaptor.RaptorID = id;

        newRaptor.Cooldown = 0;
        newRaptor.Hunger = 0;
        
        newRaptor.Head = heads[Random.Range(0, heads.Length)];
        newRaptor.Torso = torsos[Random.Range(0, torsos.Length)];
        newRaptor.Tail = tails[Random.Range(0, tails.Length)];

        return newRaptor;
    }
    
    
}
