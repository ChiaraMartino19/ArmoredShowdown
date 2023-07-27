using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car1 : CarController
{
 
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
          
            ApplyTorque(torque);
            ApplyBrake(0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            ApplyTorque(-torque); // Aplica torque negativo para ir en reversa
            ApplyBrake(0);
        }
        else
        {
            ApplyTorque(0);
            ApplyBrake(torque);
        }

        if (Input.GetKey(KeyCode.D))
        {
            ApplySteerAngle(angle);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            ApplySteerAngle(-angle);
        }
        else
        {
            ApplySteerAngle(0);
        }
       
    }
   
}
