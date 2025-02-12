using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShip : MonoBehaviour
{

    public Transform FirePoint;// 弾をを発射する位置
    public GameObject bulletPrefab;

    // 約0.02秒に一回実行される
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
