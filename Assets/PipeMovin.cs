using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovin : MonoBehaviour
{
    public float speed;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=transform.position+(Vector3.left*speed)*Time.deltaTime;
        if (transform.position.x<deadZone)
        {
            Debug.Log("pipe gone girl");
            Destroy(gameObject);
        }
    }
}
