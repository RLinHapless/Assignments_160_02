using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitManager : MonoBehaviour
{
    public List<Fruit> FruitSalad;

    // Start is called before the first frame update
    void Start()
    {
        FruitSalad = new List<Fruit>();

        Fruit apple = new Fruit("apple", Color.red, 0.7f);

        FruitSalad.Add(apple);

        CreateFruitSalad();
        DisplayFruitSalad();
    }

    private void CreateFruitSalad()
    {
        FruitSalad.Add(new Fruit());
        FruitSalad.Add(new Fruit("strawberry"));
        FruitSalad.Add(new Fruit(Color.red));
    }

    private void  DisplayFruitSalad()
    {
        for(int i = 0; i < FruitSalad.Count; i++)
        {
            //example of a code that goes past the indent line
            print(FruitSalad[i].FruitColor.ToString() + " " + FruitSalad[i].FruitName + " weighing " + 
                FruitSalad[i].FruitWeight + " units.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
