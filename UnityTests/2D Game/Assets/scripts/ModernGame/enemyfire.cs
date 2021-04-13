using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyfire : MonoBehaviour
{
    public GameObject prefab;
    public GameObject barrel;
    public int speed = 7;
    void Update()
    {

        fireEnemyProjectile();
    }
    void fireEnemyProjectile()
        {
            if (Random.Range(0f, 1500f) < 1)
            {
                GameObject EnemyBullet = Instantiate(prefab, new Vector3(barrel.transform.position.x, barrel.transform.position.y - 0.4f, 0), barrel.transform.rotation) as GameObject;
                Rigidbody2D rb = EnemyBullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * -speed;
                Destroy(EnemyBullet, 3f);
        }
        }
}