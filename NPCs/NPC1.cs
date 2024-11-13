using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NPC1 : MonoBehaviour
{
    [SerializeField] public int Health;
    [SerializeField] protected int Attack;
    [SerializeField] protected int Defence;
    [SerializeField] protected float Speed;
}
