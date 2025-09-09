using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public float startLife = 10;
    private float _currentLife;
    private bool _isDead = false;
    public bool destreyOnKill = false;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _isDead = false;
        _currentLife = startLife;
    }

    public void Damage(int damage)
    {
        if (_isDead) return;

        _currentLife -= damage;

        if (_currentLife <= 0)
        {
            kill();
        }
    }

    private void kill()
    {
        _isDead = true; 
        if (destreyOnKill)
        {
            Destroy(gameObject);
        }
    }

}
