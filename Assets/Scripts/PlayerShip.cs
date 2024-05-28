using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShip : MonoBehaviour
{

    public Transform FirePoint;// ’e‚ğ‚ğ”­Ë‚·‚éˆÊ’u
    public GameObject bulletPrefab;

    // –ñ0.02•b‚Éˆê‰ñÀs‚³‚ê‚é
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position +=new Vector3(x,y,0)*Time.deltaTime*4f;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab,FirePoint.position,transform.rotation);
        }
    }
}
