using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    [SerializeField]
    private CardModel model;
    [SerializeField]
    private TextMesh text;

    void Awake()
    {
        //string afterBreak = GUIHelper.WordWrap(model.Description, 20);
        //Debug.Log(afterBreak);
        text.text = model.Description;
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}

[System.Serializable]
public class CardModel
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

    public int Id
    {
        get
        {
            return id;
        }
    }

    private ColorType Color
    {
        get
        {
            return color;
        }
    }

    public bool IsEnchantment
    {
        get
        {
            return isEnchantment;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }
}