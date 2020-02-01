using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public PlayerController playerController;

    public void OnBeginDrag(PointerEventData eventData)
    {
        
        this.transform.SetParent(this.transform.parent.parent);
        Debug.Log("OnBeginDrag");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(this.gameObject.name == "JumpCard"){
            playerController.Jump();
        }

        if (this.gameObject.name == "FireCard")
        {
            playerController.Shoot();
        }

        Debug.Log("OnEndDrag");
        Destroy(this.gameObject);
    }
}
