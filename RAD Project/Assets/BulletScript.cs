using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float bulletspeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += bulletspeed * transform.forward * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        print("OWWw WHY?");
        Health sheep = collision.transform.GetComponent<Health>();
        if (sheep)
            sheep.takeDamage(40);
    }
}
