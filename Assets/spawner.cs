using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=2;
    private float timer=0;
    public float heightOffset =10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<spawnRate)
        {
            timer=timer+Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer=0;
        }
    }
    void spawnpipe()
    {
        float lowheight=transform.position.y-heightOffset;
        float highheight = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowheight,highheight),0), transform.rotation);

    }


}
