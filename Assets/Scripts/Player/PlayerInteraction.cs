using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float interactionRange = 5f;
    [SerializeField] private Camera playerCamera;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("E tuşuna basıldı, etkileşim deneniyor...");
            TryInteract();
        }
    }
    
    private void TryInteract()
    {
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        if (Physics.Raycast(ray, out RaycastHit hit, interactionRange))
        {
            if(hit.collider.TryGetComponent<IInteractable>(out IInteractable interactable))
            {
                interactable.Interact(gameObject);
                Debug.Log("Etkileşim gerçekleşti: " + interactable.InteractionPrompt);
            }
            
        }
        
    }
    
}
