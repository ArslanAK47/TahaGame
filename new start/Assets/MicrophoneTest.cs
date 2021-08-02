using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;


public class MicrophoneTest : MonoBehaviour
{
    GameObject dialog = null;

    void Start()
    {

        if (!Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            Permission.RequestUserPermission(Permission.Microphone);
            dialog = new GameObject();
            }

    }


        // Now you can do things with the microphone
    
}