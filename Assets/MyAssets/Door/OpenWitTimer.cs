using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWitTimer : MonoBehaviour
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
    private void Update()
    {
        if( open == true)
        {
            StartCoroutine(Timer()); 
        }
    }
    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        open = false;
        transform.position = posDefault.transform.position;
    }
}
