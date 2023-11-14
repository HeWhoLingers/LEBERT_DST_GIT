using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public void DestroyObject(float time = 0)
    {
        GameObject.Destroy(this.gameObject, time);
    }
}
