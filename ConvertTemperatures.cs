using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Exercise 7 Solution
/// </summary>

public class ConvertTemperatures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Declare int variables
        int originalFehrenheit;
        int celcius;
        int calculatedFehrenheit;

        Debug.Log("<--calculate and display for 0 degrees-->");

        // calculate and display for 0 degrees
        originalFehrenheit = 0;
        print("Original Fehrenheit: " + originalFehrenheit);
        celcius = (originalFehrenheit - 32) / 9 * 5;
        print("Calculated Celcius: " + celcius);
        calculatedFehrenheit = (celcius * 9) / 5 + 32;
        print("Calculated Fehrenheit: " + calculatedFehrenheit);



        Debug.Log("<--calculate and display for 32 degrees-->");


        // calculate and display for 32 degrees
        originalFehrenheit = 32;
        print("Original Fehrenheit: " + originalFehrenheit);
        celcius = (originalFehrenheit - 32) / 9 * 5;
        print("Calculated Celcius: " + celcius);
        calculatedFehrenheit = (celcius * 9) / 5 + 32;
        print("Calculated Fehrenheit: " + calculatedFehrenheit);


        Debug.Log("<--calculate and display 212 degrees-->");


        // calculate and display 212 degrees
        originalFehrenheit = 212;
        print("Original Fehrenheit: " + originalFehrenheit);
        celcius = (originalFehrenheit - 32) / 9 * 5;
        print("Calculated Celcius: " + celcius);
        calculatedFehrenheit = (celcius * 9) / 5 + 32;
        print("Calculated Fehrenheit: " + calculatedFehrenheit);



        Debug.Log("<--calculate and display for 0 degrees using float-->");


        // declare float variables
        float floatOriginalFehrenheit;
        float floatCelcius;
        float floatCalculatedFehrenheit;



        // calculate and display for 0 degrees using float
        floatOriginalFehrenheit = 0;
        print("Float Original Fehrenheit: " + floatOriginalFehrenheit);
        floatCelcius = (floatOriginalFehrenheit - 32) / 9 * 5;
        print("Float Calculated Celcius: " + floatCelcius);
        floatCalculatedFehrenheit = (floatCelcius * 9) / 5 + 32;
        print("Float Calculated Fehrenheit: " + floatCalculatedFehrenheit);


        Debug.Log("<--calculate and display for 0 degrees using double-->");


        // declare double variables
        double doubleOriginalFehrenheit;
        double doubleCelsius;
        double doubleCalculatedFehrenheit;


        // calculate and display for 0 degrees using double
        doubleOriginalFehrenheit = 0;
        print("Double Original Fehrenheit: " + doubleOriginalFehrenheit);
        doubleCelsius = (doubleOriginalFehrenheit - 32) / 9 * 5;
        print("Double Calculated Celcius: " + doubleCelsius);
        doubleCalculatedFehrenheit = (doubleCelsius * 9) / 5 + 32;
        print("Double Calculated Fehrenheit: " + doubleCalculatedFehrenheit);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
