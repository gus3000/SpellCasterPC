using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    [SerializeField]
    private CardModel model;
    [SerializeField]
    private TextMesh titleText;
    [SerializeField]
    private TextMesh descriptionText;

    [SerializeField]
    private Material[] cardTextures;
    [SerializeField]
    private GameObject front;

    void Awake()
    {
        //initialize card texture data
        titleText.text = model.Title;
        descriptionText.text = model.Description;
        Material toApply = cardTextures[(int)model.Color];
        MeshRenderer frontRenderer = front.GetComponent<MeshRenderer>();

        frontRenderer.material = toApply;
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
    public enum ColorType { Combat, Healing, Sorcery, Conjuring };

    //local
    [SerializeField]
    private int id;
    [SerializeField]
    private ColorType color;

    //private Effect effect;
    [SerializeField]
    private bool isEnchantment;

    [SerializeField]
    private string title;
    [SerializeField]
    private string description;

    public int Id
    {
        get
        {
            return id;
        }
    }

    public ColorType Color
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

    public string Title
    {
        get
        {
            return title;
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