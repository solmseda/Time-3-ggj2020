﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler,IPointerEnterHandler, IPointerExitHandler
{
    public PlayerController playerController;
    public void OnDrop(PointerEventData eventData)
    {
        Draggable card = eventData.pointerDrag.GetComponent<Draggable>();
        if (card != null)
        {
            card.parentToReturnTo = this.transform;
           

            
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
}
