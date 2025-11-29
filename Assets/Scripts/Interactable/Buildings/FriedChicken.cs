using UnityEngine;
using UnityEngine.SceneManagement;

public class FriedChicken : MonoBehaviour, IInteractable
{
    public string InteractionPrompt => "Tavuk dükkanına girmek için E'bas!";

    public void Interact(GameObject interactor)
    {
        Debug.Log("Tavuk dükkanına girildi!");
        LoadFriedChickenRestaurant();
        
    }

    private void LoadFriedChickenRestaurant()
    {
        SceneManager.LoadScene("BLD_RESTAURANT_FRIEDCHICKEN");
    } 

}
