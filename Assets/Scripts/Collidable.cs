using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        OnGamePlayCollision();
    }

    public virtual void OnGamePlayCollision()
    {
        
    }
}
