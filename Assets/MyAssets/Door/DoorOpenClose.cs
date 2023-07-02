using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenClose : MonoBehaviour
{

    public Transform posOpen;
    public Transform posDefault;
    bool open = false;
    public void OpenDoor()
    {
        if (open == false)
        {
            transform.position = posOpen.transform.position;
            open = true;
        }
    }
    public void CloseDoor()
    {
        if (open == true)
        {
            transform.position = posDefault.transform.position;
            open = false;
        }

    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
