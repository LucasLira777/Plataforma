using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class ProjectileBase : MonoBehaviour
{
    public Vector3 direction;
    public float timeToDestroy = 1f;
    public float side = 1;
    public int damageAmount = 1;

    private void Awake()
    {
        Destroy(gameObject, timeToDestroy);
    }


    private void Update()
    {
        transform.Translate(direction * Time.deltaTime * side);   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.transform.GetComponent<Enemybase>();

        if(enemy != null)
        {
            enemy.Damage(damageAmount);
            Destroy(gameObject);
        }
    }
}
