using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System;

public class JungleTimer : MonoBehaviour
{
    List<GameObject> _monsters = new List<GameObject>(12);
    List<GameObject> _monstersPosition = new List<GameObject>(12);
    List<float> _monsterTimer = new(12);

    async void Respawn(int time, GameObject Monster, Transform Position,Quaternion Quaternion)
    {
        await Task.Delay(TimeSpan.FromSeconds(time));
        Instantiate(Monster, Position.position, Quaternion);
    }
}
