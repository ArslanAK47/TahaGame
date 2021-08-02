using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public string TextValue;
    public Text TextElement;
    public double longitude1;
    public double latitude1;
    Location_finder location_finder;

    public void get_location(double loci, double loci2) {
        TextElement.text = (loci.ToString() + " , " + loci2.ToString());
    }

    // Start is called before the first frame update
    void Start()
    {
        location_finder = FindObjectOfType<Location_finder>();
        longitude1 = location_finder.longitude;
        latitude1 = location_finder.latitude;
    }

    // Update is called once per frame
    void Update()
    {
        get_location(longitude1,latitude1);
    }
}
