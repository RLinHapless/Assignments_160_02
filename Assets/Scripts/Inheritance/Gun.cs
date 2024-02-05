using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Weapon
{

    //base means base class (default constructor)
    public Gun() : base()
    {
        base.WeaponName = "TommyGun";
        WeaponStrength = 700;
    }

    public Gun(string wName)
    {
        WeaponName = wName;
        WeaponStrength += 10;
    }
}
