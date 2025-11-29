using UnityEngine;
using UnityEngine.SceneManagement;

public class Building : MonoBehaviour, IInteractable
{
    public string InteractionPrompt => "Binaya gir";

    public void Interact(GameObject interactor)
    {
        Debug.Log("Etkileşim gerçekleşti: " + InteractionPrompt);
        LoadScene();

    }
    
    private void LoadScene()
    {
        SceneManager.LoadScene("BUILDING_INSIDE");
    }
}
