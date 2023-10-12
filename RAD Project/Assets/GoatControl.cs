using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoatControl : MonoBehaviour
{
    private Animator SK_goat_dark;

    public GameObject bulletCloneTemplate;
    // Start is called before the first frame update
    void Start()
    {
        SK_goat_dark = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // s = u t   s- distance = u (velocity)  * (time)

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Vector3.up * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.W))
        {
            SK_goat_dark.SetBool("isWalkiing", true);
            transform.position += Vector3.forward * Time.deltaTime;
            

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bulletCloneTemplate,transform.position + transform.up+ transform.forward,transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("OWW");
    }
}
