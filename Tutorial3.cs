// Under LICENSE: Radioxians SA LICENSE (Source Avaible)

// © 2026 Radioxians Studios. All Rights Reserved.
// v 1.0
//  You can study and observe this script, but you cannot modify it, publish it, or sell it; it will violate the copyright (©) of Radioxians Studios.
// This script is on Git Hub

using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Tutorial3 : MonoBehaviour
{
    float pizzaPrice = 6;
    float hotDogPrice = 3;
    float money = 5;

    string pizzaType = "Margherita";
    string hotDogType = "Onion";

    float spicyHotDogLevel = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pizzaPrice <= 5 && pizzaType == "Margherita")
        {
            Debug.Log("OK, I will spend " + pizzaPrice + " for a " + pizzaType);
        }
        else
        {
            Debug.Log("Not good, I won't get the " + pizzaType);
        }

        if (hotDogPrice <= 3 || (hotDogType == "NoOnion" && spicyHotDogLevel == 1))
        {
            Debug.Log("This works for me");
        }
        else
        {
            Debug.Log("I don't like it, I won't get the hot dog");
        }

        if (money >= 5)
        {
            Debug.Log("I have enough money");
        }
        else
        {
            Debug.Log("I don't have enough money");
        }

        switch (spicyHotDogLevel)
        {
            case 1:
                Debug.Log("OK");
                break;

            case 2:
                Debug.Log("I'm not taking it!");
                break;

            case 3:
                Debug.Log("TOO SPICY!");
                break;

            default:
                Debug.Log("Is this even a hot dog?!");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("You jumped!");
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("You stopped jumping!");
        }
    }
}
