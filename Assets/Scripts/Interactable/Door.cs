using DG.Tweening;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;
    private bool isOpen = false;

    public string InteractionPrompt => isOpen ? "Kapıyı Kapat" : "Kapıyı Aç";

    public void Interact(GameObject interactor)
    {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
        Debug.Log(isOpen ? "Kapı açıldı." : "Kapı kapandı.");
        OpenDoor();
    }
    

    void OpenDoor()
    {
        transform.DOMove(new Vector3(transform.position.x, 10, transform.position.z), 3f);
    }
    
}
