using DG.Tweening;
using UnityEngine;

public class DoorTrigger : MonoBehaviour, IInteractable
{
    public GameObject door;
    public string InteractionPrompt => "Kapıyı Kapat";
    public void Interact(GameObject interactor)
    {
        CloseDoor();
    }
    
    void CloseDoor()
    {
        door.transform.DOMove(new Vector3(door.transform.position.x, 3.5f, door.transform.position.z), 3f);
    }
}
