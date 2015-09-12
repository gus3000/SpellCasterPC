using UnityEngine;
using System.Collections;

public class TextFitter : MonoBehaviour
{
    private TextMesh text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<TextMesh>();
        string s = GUIHelper.WordWrap(text.text, 40);
        s = s.Replace("(C)", "<quad material=1 size=100 x=0 y=0 width=1 height=1/>");
        s = s.Replace("(S)", "<quad material=2 size=100 x=0 y=0 width=1 height=1/>");

        text.text = s;
    }
    
    void Fit()
    {

    }
}
