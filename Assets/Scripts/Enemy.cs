using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    public float moveSpeed = 1;
    public int id { set; get; }

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        navMeshAgent.speed = moveSpeed;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
    }
}
