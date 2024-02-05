using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Gun tommyGun;
    private Gun Revolver;

    // Start is called before the first frame update
    void Start()
    {
        tommyGun = new Gun();
        Revolver = new Gun("Revolver");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
