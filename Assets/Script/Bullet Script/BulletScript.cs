using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_Timer = 3f;
    [HideInInspector] public bool isEnemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0,0,90);
        if (isEnemyBullet)
            speed *= -1f;

        Invoke("DeactivateGameObject", deactivate_Timer);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }

    void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D target)
    {

        if (target.tag=="Bullet" || target.tag == "Enemy")
        {
            Destroy(gameObject,.0f);

            // gameObject.SetActive(false);
        }
        
    }
}