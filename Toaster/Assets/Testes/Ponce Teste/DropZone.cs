using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler,IPointerEnterHandler, IPointerExitHandler
{
    public PlayerController playerController;
    public GameObject card;
    public void OnDrop(PointerEventData eventData)
    {
        
        
            if ( card.name == "JumpCard")
            {
                playerController.Jump();
                Destroy(card.gameObject);
            }

            if (card.name == "FireCard")
            {
                playerController.Shoot();
                Destroy(card.gameObject);
            }

            
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
