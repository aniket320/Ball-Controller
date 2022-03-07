using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class enemy : MonoBehaviour
{
    public NavMeshAgent car;
    public Transform position;
    //public float speed;
  

    // Update is called once per frame
    void Start()
    {
        car = GetComponent<NavMeshAgent>();
        car.SetDestination (position.position);
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("end"))
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            var ob = collision.gameObject.transform;
            ob.parent = transform;
//StartCoroutine(stickt());
        }
       

    }

    

}
