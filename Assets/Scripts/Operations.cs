using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 2f;
    public float y = 5f;

    private void Calculator ( float x, float y)
    {
        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x + y));
        Debug.Log(string.Format("substraccion {0} - {1} = {2}", x, y, x - y));
        Debug.Log(string.Format("product {0} * {1} = {2}", x, y, x * y));
        Debug.Log(string.Format("division {0} / {1} = {2}", x, y, x / y));
    }

    



    private void Start()
    {
        Calculator(7, 4);

        /* Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x+y));


        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x-y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x/y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x*y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x%y));
     */

}

}
