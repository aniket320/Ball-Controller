using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class finishline : MonoBehaviour
{
    [SerializeField] GameObject playerpos;
    [SerializeField] GameObject finishlinepos;
    public Slider player;
    float distance;
    // Start is called before the first frame update
    void Start()
    {
        finishlinepos = GameObject.FindGameObjectWithTag("endline");
        distance = finishlinepos.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.value < 1)
        {
            player.value = playerpos.transform.position.z / distance;
        }
    }
}
