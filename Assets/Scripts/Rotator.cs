using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Quaternion _quaternion;
    void Start()
    {
        //transform.rotation = _quaternion;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = _quaternion;
    }
}
