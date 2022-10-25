using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScrip : MonoBehaviour
{/*
    public int playerAge = 33;
    private float playerSpeed = 3.125f;
    public string playerName = "Miguel";
    [SerializeField] private bool gameOver = false;

    public string message = "Hola mundo";
    public int points = 256;

    //operadores de decison
    public bool isRaining = true;
    public float number;
    public int number1;
    public int number2;
    public bool isOfLegalAge;
    public bool hasMoney;
    */
    public Vector3 initialPos = new Vector3(1, 1, 1);

    private void Start()
    {
        /*
        Debug.Log(message);
        Debug.Log(points);
        Debug.Log($"Tengo {points} puntos");

        Debug.Log(string.Format("Hola {0} tienes {1} puntos", playerName, points));
        Debug.Log("Tengo" + points + "puntos");

        if (isRaining == true)
        {
            Debug.Log("recuerda coger paraguas");
            }
        if ( number > 0)
        {
            Debug.Log($"El número {number} es positivo");
        }
        if (number1 == number2)
        {
            Debug.Log("Los dosnúmeros son iguales");
        }

        if (isOfLegalAge == true)
        {
            Debug.Log("Puees entrar ala discoteca");
            
        }else if (hasMoney == true)
        {
            Debug.Log("Eres menor, pero puedes entrar a la desciteca");
        }
        else
        {
            Debug.Log("no puedes entrar");
        }
        */

        transform.position = initialPos

    }



   

}
