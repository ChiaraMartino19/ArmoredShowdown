using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : ShootingController
{

    private void Update()
    {
        MyInput();

        //Set ammo display, if it exists :D
        if (ammunitionDisplay != null)
            ammunitionDisplay.text = bulletsLeft.ToString();
    }
    private void MyInput()
    {
        //Check if allowed to hold down button and take corresponding input
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.E);
        else shooting = Input.GetKeyDown(KeyCode.E);

        //Shooting
        if (readyToShoot && shooting && bulletsLeft > 0)
        {
            //Set bullets shot to 0
            bulletsShot = 0;

            Shoot();
        }
    }
}
