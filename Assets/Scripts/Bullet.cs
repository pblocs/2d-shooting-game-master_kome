using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 3f, 0)*Time.deltaTime;
    }
}
