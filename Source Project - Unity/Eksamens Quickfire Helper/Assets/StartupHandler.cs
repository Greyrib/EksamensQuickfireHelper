using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartupHandler : MonoBehaviour
{
    public static StartupHandler instance;

    void Awake ()
    {
        if (instance == null) instance = this; else Destroy (this);

        Start_Setup ();
    }

    void Start_Setup ()
    {
        
    }



}
