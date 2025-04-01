using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransformer : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.forward + transform.position, _movementSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += _scaleSpeed * new Vector3(1, 1, 1) * Time.deltaTime;
    }
}
