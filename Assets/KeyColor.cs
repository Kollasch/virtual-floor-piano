using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class KeyColor : MonoBehaviour
{
    public Color WhiteKey = new Color(215, 215, 215);
    public Color BlackKey = new Color(0, 0, 0);

    private Color currentColor;
    private Material materialColored;

    void Start()
    {
        
       materialColored = new Material(Shader.Find("Diffuse"));
       if (this.gameObject.tag == "WhiteKey")
       {
            materialColored.color = currentColor = WhiteKey;
        }
        else
        {
            materialColored.color = currentColor = BlackKey;
        }

        this.GetComponent<Renderer>().material = materialColored;

    }
}