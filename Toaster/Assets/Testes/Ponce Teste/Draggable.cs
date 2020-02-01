using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public PlayerController playerController;

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);

        //GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

        this.transform.SetParent(parentToReturnTo);

        HandleCardSkills();


        //GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    private void HandleCardSkills()
    {
        if (this.gameObject.name == "JumpCard")
        {
            playerController.Jump();
            Destroy(this.gameObject);
        }

        if (this.name == "FireCard")
        {
            playerController.Shoot();
            Destroy(this.gameObject);
        }

        if (this.name == "GhostCard")
        {
            playerController.GhostSkill();
            Destroy(this.gameObject);
        }

        if (this.name == "DoubleShootCard")
        {
            playerController.DoubleShot();
            Destroy(this.gameObject);
        }

        if(this.name == "SlowTimeCard")
        {
            playerController.SlowPlayer();
            Destroy(this.gameObject);
        }
    }
}
