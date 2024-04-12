using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTriangle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += 0.1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= 0.1f;
        }

        transform.position = pos;
        
    }
}
