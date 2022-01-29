using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    IInteract interactable;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(PlayerKeyBindings.Instance.InteractKey) && interactable != null)
        {
            interactable.Interact();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<IInteract>() != null)
        {
            interactable = collision.GetComponent<IInteract>();
        }
        else
        {
            interactable = null;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        interactable = null;
    }
}
