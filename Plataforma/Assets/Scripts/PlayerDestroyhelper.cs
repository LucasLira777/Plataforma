using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroyhelper : MonoBehaviour
{
    public Player player; 
    public void Killplayer()
    {
        player.DestroyMe();
    }
}
