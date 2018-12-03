using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFirePoint : MonoBehaviour
{

    public bool TurnLeft;

    // Update is called once per frame
    void Update()
    {
        //Om A används och turn left är true rotera 180 grader och ge Turnleft false så den inte kan upprepas
        if (Input.GetKey(KeyCode.A) && TurnLeft == true)
        {
            transform.Rotate(0, 180, 0);
            TurnLeft = false;
        }
        //Om D används och turn left är false rotera -180 grader och ge TurnLeft true så den inte kan upprepas
        if (Input.GetKey(KeyCode.D) && TurnLeft == false)
        {
            transform.Rotate(0, -180, 0);
            TurnLeft = true;
        }
    }
}