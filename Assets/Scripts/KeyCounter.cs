using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCounter : MonoBehaviour
{

    public DoorOpener doorOpen;

    // Update is called once per frame
    void Update()
    {
        //om key get är högre än 0 destroy game object
        if(doorOpen.keyGet > 0)
        {
            Destroy(gameObject);
        }
    }
}
