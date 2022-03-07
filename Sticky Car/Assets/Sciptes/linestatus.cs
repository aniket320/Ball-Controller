using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linestatus : MonoBehaviour
{

    public void online()
    {
        GetComponent<LineRenderer>().enabled = true;
    }
    public void Ofline()
    {
        GetComponent<LineRenderer>().enabled = false;
    }
}
