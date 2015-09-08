using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    [SerializeField]
    private CardModel model;
    [SerializeField]
    private int test;

    void Start()
    {

    }

    void Update()
    {
        
    }
}


public class CardModel : MonoBehaviour
{
    //global
    enum ColorType { Combat, Conjuring, Healing, Sorcery };

    //local
    [SerializeField]
    private int id;
    [SerializeField]
    private ColorType color;

    //private Effect effect;
    [SerializeField]
    private bool isEnchantment;
    [SerializeField]
    private string description;
}