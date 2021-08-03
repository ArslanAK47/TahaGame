using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;
using UnityEngine.Networking;
public class Location_finder : MonoBehaviour
{
    public Text gpsOut;
    public bool isUpdating;
    public double latitude;
    public double longitude;
   
    public void Update()
    {

        if (!isUpdating)
        {
            StartCoroutine(GetLocation());
            isUpdating = !isUpdating;
        }
    }
    IEnumerator GetLocation()
    {
        latitude = 31.4517;
        longitude = 74.2937;
        if (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
        {
            Permission.RequestUserPermission(Permission.FineLocation);
            Permission.RequestUserPermission(Permission.CoarseLocation);
        }
        // First, check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            yield return new WaitForSeconds(0);

        // Start service before querying location
        Input.location.Start();

        // Wait until service initializes

        // Service didn't initialize in 20 seconds

        // Connection has failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            gpsOut.text = "Unable to determine device location";
            print("Unable to determine device location");
            yield break;
        }
        else
        {
           // Access granted and location value could be retrieved
             latitude = Input.location.lastData.latitude;
            longitude = Input.location.lastData.longitude;
            gpsOut.text = "Location: " + latitude.ToString() + ", " + longitude.ToString();
        }

        // Stop service if there is no need to query location updates continuously
        isUpdating = !isUpdating;
        Input.location.Stop();
    }


}
