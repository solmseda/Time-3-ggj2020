using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public struct card
    {
        public GameObject CardInHand;
        public bool wasUsed;
    }

    [Tooltip("Cartas que podem ser adicionadas a mão")]
    public GameObject[] deck;
    public card[] hand;
    public int handSize = 4;
    public bool usedCard = false; // está bool é usada no script Draggable para mostrar que uma carta foi usada
    [SerializeField]
    public int newCard; //carta aleatoria a ser adicionada na mão
    
    private int aux; //aux para ser usado como contador

    void Start()
    {
        hand = new card[handSize];
        for(int i = 0; i < handSize; i++){
            aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
            hand[i].CardInHand = deck[aux]; // seta a carta aleatoria em uma posição na mão
            hand[i].wasUsed = false;
        }
        
    }

    void Update()
    {
        /*---Controle da mão---*/
        if(hand[0].wasUsed == true){
           for(int i = 0; i < handSize; i++){
                hand[i] = hand[i+1]; // passa o próximo valor para a posição atual
            }
            aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
            hand[handSize].CardInHand = deck[aux]; // seta a carta aleatoria no final da mão
            hand[0].wasUsed = false;
        }
        else if(hand[1].wasUsed == true){
            for(int i = 1; i < handSize; i++){
                hand[i] = hand[i+1]; // passa o próximo valor para a posição atual
            }
            aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
            hand[handSize].CardInHand = deck[aux]; // seta a carta aleatoria no final da mão
            hand[1].wasUsed = false;
        }
        else if (hand[2].wasUsed == true){
            for(int i = 2; i < handSize; i++){
                hand[i] = hand[i+1]; // passa o próximo valor para a posição atual
            }
            aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
            hand[handSize].CardInHand = deck[aux]; // seta a carta aleatoria no final da mão
            hand[2].wasUsed = false;
        }
        else if (hand[3].wasUsed == true){
            hand[handSize].CardInHand = deck[aux]; // seta a carta aleatoria no final da mão
            hand[3].wasUsed = false;
        }

        /*---Instaciar a carta na ultima posição da mão---*/
        if (usedCard)
        {
            Instantiate(hand[handSize].CardInHand, this.transform);

        }

    }
}
