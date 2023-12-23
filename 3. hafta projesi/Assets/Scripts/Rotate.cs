using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 vect3;
    private void Update()
    {

        GetComponent<Transform>().Rotate(vect3);
    }
}
