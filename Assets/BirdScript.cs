using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D jimRigid;
    public float flap;
    public logiScript logic;
    public bool birdlive=true;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name="jim";
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logiScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)==true && birdlive==true)
            {
                jimRigid.velocity=Vector2.up*flap;
            }

    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        birdlive=false;
    }
}
