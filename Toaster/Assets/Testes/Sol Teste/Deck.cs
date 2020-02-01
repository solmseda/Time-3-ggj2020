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
        if(hand[0].wasUsed == true){
           for(int i = 0; i < handSize; i++){
                aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
                hand[i].CardInHand = deck[aux]; // seta a carta aleatoria e adiciona na posição 1 da mão
                hand[i].wasUsed = false;
            } 
        }
        else if(hand[1].wasUsed == true){
            for(int i = 1; i < handSize; i++){
                aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
                hand[i].CardInHand = deck[aux]; // seta a carta aleatoria e adiciona na posição 2 da mão
                hand[i].wasUsed = false;
            }
        }
        else if (hand[2].wasUsed == true){
            for(int i = 2; i < handSize; i++){
                aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
                hand[i].CardInHand = deck[aux]; // seta a carta aleatoria e adiciona na posição 3 da mão
                hand[i].wasUsed = false;
            }
        }
        else if (hand[3].wasUsed == true){
            for(int i = 3; i < handSize; i++){
                aux = Random.Range(0, deck.Length); // pega um uma carta aleatoria do deck
                hand[i].CardInHand = deck[aux]; // seta a carta aleatoria e adiciona na posição 4 da mão
                hand[i].wasUsed = false;
            }
        }
    }
}
