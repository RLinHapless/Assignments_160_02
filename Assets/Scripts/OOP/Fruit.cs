using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string FruitName;
    public Color FruitColor;
    public float FruitWeight;

    public Fruit(string n, Color c, float w)
    {
        FruitName = n;
        FruitColor = c;
        FruitWeight = w;
    }

    //default constructor. Whenever an instance of fruit is instantiated without any params, this will be the default.
    public Fruit() 
    {
        FruitName = "mandarin";
        FruitColor = Color.yellow;
        FruitWeight = 1.0f;
    }

    public Fruit(string n)
    {
        FruitName = n;
        FruitColor = Color.blue;
        FruitWeight = 1.3f;
    }

    public Fruit(Color c)
    {
        FruitName = "watermelon";
        FruitColor = c;
        FruitWeight = 5.8f;
    }

    ~Fruit() //le destructor
    {
        FruitName = null;
        FruitColor = Color.clear;
        FruitWeight = 0.0f;
    }
}
