using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    [SerializeField] private int wheels = 4;
    [SerializeField] private string name = "car";
    [SerializeField] private bool isOn;
    [SerializeField] private float gasoline;
    public string sound;

    private void Start()
    {
        Debug.Log(string.Format("El {0} tienes {1} ruedas", name, wheels));
        if (isOn == true)
        {
            Debug.Log(string.Format("El {0} esta encendido",name));
            if (gasoline < 10)
            {
                Debug.Log(string.Format("A {0} le queda pocagasolina", name));
            }
        }
        else 
        {
            Debug.Log(string.Format("El {0} esta apagado", name));
        }

        if (isOn == false)
        {
            Debug.Log(string.Format("El {0} esta apagado", name));
        }
        else if (sound != "")
        {
            Debug.Log(string.Format("El {0} esta encendido y hace {1}", name, sound));
        }
        else
        {
            Debug.Log(string.Format("El {0} esta en marcha", name));
        }

        if (isOn == true && gasoline < 10)
        {
            Debug.Log(string.Format("A {0} le queda poca gasolina", name));
        }

    }

}
