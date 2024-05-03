using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting3 : MonoBehaviour
{
    public GameObject bullet;

    public Transform bulletPos;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 2){
            timer = 0;
            shoot();
        }
    }

    void shoot(){
        GameObject bullet = ObjectPool.Instance.GetPooledObject();
        if (bullet != null){
            bullet.transform.position = bulletPos.position;
            bullet.SetActive(true);
        }
        else{
            bullet.SetActive(false);
        }
    }

    
}
