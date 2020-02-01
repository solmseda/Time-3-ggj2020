using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public PlayerController playerController;
    public GameObject hand;
    public GameObject[] cards;
    private int index;
    private GameObject newCard;
    

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
        index = Random.Range(0, cards.Length - 1);
        newCard = cards[index];
        Instantiate(newCard, hand.transform);
        newCard.transform.SetParent(hand.transform);


        this.transform.SetParent(parentToReturnTo);

        HandleCardSkills();
        

        //GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    private void HandleCardSkills( )
    {
        if (this.gameObject.name == "JumpCard" || this.CompareTag("JumpCard"))
        {
            playerController.Jump();
            Destroy(this.gameObject);
            
        }

        if (this.name == "FireCard" || this.CompareTag("FireCard"))
        {
            playerController.Shoot();
            Destroy(this.gameObject);
            
        }

        if (this.name == "GhostCard"  || this.CompareTag("GhostCard"))
        {
            playerController.GhostSkill();
            Destroy(this.gameObject);
            
        }

        if (this.name == "DoubleShootCard" || this.CompareTag("DoubleShootCard"))
        {
            playerController.DoubleShot();
            Destroy(this.gameObject);
            
        }

        if(this.name == "SlowTimeCard" || this.CompareTag("SlowTimeCard"))
        {
            playerController.SlowPlayer();
            Destroy(this.gameObject);
            
        }
    }
}
