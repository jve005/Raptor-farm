using UnityEngine;

public class RaptorGeneration : MonoBehaviour
{
    public GameManager gameManager;
    private ContainerManager containerManager;
    
    public void CreateRaptor(int id)
    {
        Raptor raptor = new Raptor();

        gameManager.GenerateRaptor(raptor);
    }
}
