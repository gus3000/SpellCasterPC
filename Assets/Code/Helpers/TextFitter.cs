using UnityEngine;
using System.Collections;

public class TextFitter : MonoBehaviour
{
    private TextMesh text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<TextMesh>();
        text.text = GUIHelper.WordWrap(text.text, 40);

    }
    
    void Fit()
    {

    }
}
