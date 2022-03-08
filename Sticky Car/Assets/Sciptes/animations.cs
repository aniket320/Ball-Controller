using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class animations : MonoBehaviour
{
    public Animator playerani;
    public Rigidbody player;
    public GameObject Retry;
    public GameObject complete;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        playerani = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("pressed");
            Jump();

        }
        //InvokeRepeating("RefreshPos", 0.1f*Time.deltaTime, 0.1f )  ;
    }


   public void Jump()
    {
        playerani.SetBool("idle", false);
        playerani.SetBool("jump", true);
        StartCoroutine(Idle());
    }

    IEnumerator Idle()
    {
        yield return new WaitForSeconds(0.37f);
        RefreshPos();
    }

    void RefreshPos()
    {
        playerani.SetBool("idle", true);
        playerani.SetBool("jump", false);
    }


   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("other"))
        {
            Destroy(GetComponent<Animator>());
            Retry.SetActive(true);
        }

        if (collision.collider.CompareTag("hanger"))
        {
            RefreshPos();    
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

   


   

}

