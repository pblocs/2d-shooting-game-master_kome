using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerShip : MonoBehaviour
{

    public Transform FirePoint;// �e���𔭎˂���ʒu
    public GameObject bulletPrefab;

    // ��0.02�b�Ɉ����s�����
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
