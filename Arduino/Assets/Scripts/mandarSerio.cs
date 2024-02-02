using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mandarSerio : MonoBehaviour
{
    public SerialController serialController;


    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Sending A");
            serialController.SendSerialMessage("A");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Sending Z");
            serialController.SendSerialMessage("Z");
        }
    }
}
