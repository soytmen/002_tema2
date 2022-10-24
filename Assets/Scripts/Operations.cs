using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operations : MonoBehaviour
{
    public float x = 2f;
    public float y = 5f;

    private void Start()
    {
        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x+y));


        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x-y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x/y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x*y));

        Debug.Log(string.Format("sum {0} + {1} = {2}", x, y, x%y));


    }
}
