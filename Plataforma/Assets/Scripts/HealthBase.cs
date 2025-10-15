using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthBase : MonoBehaviour
{
    public float startLife = 10;
    private float _currentLife;
    private bool _isDead = false;
    public bool destreyOnKill = false;

    [SerializeField]public FlashCollor _flashColor; 

    private void Awake()
    {
        Init();
        if(_flashColor == null)
        {
            _flashColor = GetComponent<FlashCollor>();
        }
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

        if (_flashColor != null)
        {
            _flashColor.Flash();
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
