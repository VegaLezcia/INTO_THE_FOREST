using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDecreasingPlayerLife : MonoBehaviour
{
    private Transform player;
    private float dist;
    public float howClose;
    //private PlayerHealth playerHealth;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);

        if (dist <= howClose)
        {
            player.GetComponent<PlayerHealth>().TakeDamage(0.02f);
        }

    }
}
