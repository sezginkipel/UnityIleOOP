using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToMainScene : MonoBehaviour, IInteractable
{
    public PlayerStateSaveManager _saveManager;
    public string InteractionPrompt => "Ana sahneye çıkmak için E'basın!";

    public void Interact(GameObject interactor)
    {
        _saveManager.SavePlayerStats();
        SceneManager.LoadScene("LAB");
    }

}
