using UnityEngine;

public class FriedChickenNPC : MonoBehaviour, IInteractable
{
    [SerializeField] public GameObject menuPanel;
    public string InteractionPrompt => "Yemek menüsünü açmak için E'bas.";

    public void Interact(GameObject interactor)
    {
        Debug.Log("Yemek menüsü açılıyor!");
        ShowMenu();
    }

    private void ShowMenu()
    {
        menuPanel.SetActive(true);
    }
}
