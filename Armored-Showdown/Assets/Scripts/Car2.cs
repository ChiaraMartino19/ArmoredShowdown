using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car2 : CarController
{
 

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            ApplyTorque(torque);
            ApplyBrake(0);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            ApplyTorque(-torque); // Aplica torque negativo para ir en reversa
            ApplyBrake(0);
        }
        else
        {
            ApplyTorque(0);
            ApplyBrake(torque);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            ApplySteerAngle(angle);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            ApplySteerAngle(-angle);
        }
        else
        {
            ApplySteerAngle(0);
        }
      
    }
   
}