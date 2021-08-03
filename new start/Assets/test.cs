using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public Text TextElement;
    public double longitude1;
    public double latitude1;
    Location_finder loca;
    public void get_location(double loci, double loci2) {
        TextElement.text = (loci.ToString() + " , " + loci2.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        loca = GameObject.Find("Map").GetComponent<Location_finder>();
        
    }

    // Update is called once per frame
    void Update()
    {
        longitude1 = loca.longitude;
        latitude1 = loca.latitude;
        get_location(longitude1,latitude1);
    }
}
