using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody brb;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        brb = GetComponent<Rigidbody>();

        brb.velocity = transform.forward * speed;

        gameObject.transform.LookAt(target);

        Destroy(gameObject, 3f);
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController pc = other.GetComponent<PlayerController>();
            BossPlayerController PC = other.GetComponent<BossPlayerController>();

            if (pc != null)
            {
                pc.Die();
            }
            else if (PC != null)
            {
                PC.Die();
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.LookAt(target);
    }
}
