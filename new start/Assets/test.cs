using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public string TextValue;
    public Text TextElement;

    public void get_location(double loci) {
        TextElement.text = loci.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        get_location(23.12);
    }
}
