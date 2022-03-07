using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemami : MonoBehaviour
{
    public Animator playerani;
    public Rigidbody player;
    public GameObject complete;
    public GameObject hangers;

    public float close;
    private float dist;
    public float stick = 5;

    private void Awake()
    {
        hangers = GameObject.FindGameObjectWithTag("bh");

    }
    void Start()
    {
        player = GetComponent<Rigidbody>();
        playerani = GetComponent<Animator>();
    }

    void Update()
    {
        hangers = GameObject.FindGameObjectWithTag("bh");
       // transform.LookAt(hangers.transform, Vector3.up);
        dist = Vector3.Distance(transform.position, hangers.transform.position);
        if (dist < close)
        {
           Jump();
        }
    /// InvokeRepeating("RefreshPos", 0.1f, 0.1f )  ;
    }


    public void Jump()
    {
       
        StartCoroutine(gravity());
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(0.5f);
        playerani.SetBool("idle", true);
        playerani.SetBool("jump", false);
    }

    void RefreshPos()
    {      
        playerani.SetBool("idle", false);
        playerani.SetBool("jump", true);
        StartCoroutine(Idle());
    }


    IEnumerator gravity()
    {
        yield return new WaitForSeconds(1);
        float steps = 3 * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, hangers.transform.position, steps);


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bh"))
        {
          
        }

        if (collision.collider.CompareTag("hanger"))
        {
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("endline"))
        {
            Debug.Log("com");
            complete.SetActive(true);
        }

    }

    public void leave()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        stick = 5;
        Jump();
        StartCoroutine(en());
    }


    IEnumerator en()
    {
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<Collider>().enabled = true;
    }


    IEnumerator sticktime()
    {
        yield return new WaitForSeconds(stick);
        gameObject.gameObject.transform.parent = null;
       // StartCoroutine(Recheck());

    }
}
