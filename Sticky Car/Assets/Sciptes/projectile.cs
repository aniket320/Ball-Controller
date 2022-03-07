using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    look looks;
    LineRenderer line;

    public int points = 50;
    public float timeinpoints = 0.1f;
    public LayerMask balllayer;
    // Start is called before the first frame update
    void Start()
    {
        looks = GetComponent<look>();
        line = GetComponent<LineRenderer>();
    }


    void LateUpdate()
    {
        line.positionCount = points;
        List<Vector3> point = new List<Vector3>();
        Vector3 startpos = looks.shootpoint.position;
        Vector3 velo = looks.shootpoint.up * looks.power;
        for (float time = 0; time < points; time += timeinpoints)
        {
            Vector3 newpoint = startpos + time * velo;
            newpoint.y = startpos.y + velo.y * time + Physics.gravity.y / 2 * time * time;
            point.Add(newpoint);

            if (Physics.OverlapSphere(newpoint, 2, balllayer).Length > 0)
            {
                line.positionCount = point.Count;

            }



            line.SetPositions(point.ToArray());

        }


    }
}
