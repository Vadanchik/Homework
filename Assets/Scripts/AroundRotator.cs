using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    void Update()
    {
        transform.Rotate(_rotateSpeed * Vector3.up * Time.deltaTime);
    }
}
