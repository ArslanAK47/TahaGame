using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    public Text TextElement;
    public Text TextElement2;
    public double longitude1;
    public double latitude1;
    public string _location_final;
    Location_finder loca;
    public void get_location(double loci, double loci2) {

        TextElement.text = (loci.ToString()+ loci2.ToString());
        TextElement2.text = (loci2.ToString() + loci.ToString());
        string _location_longitude = loci.ToString();
        string _location_latitude = loci2.ToString();
        _location_final = _location_latitude+","+ _location_longitude;

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
