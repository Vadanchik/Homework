using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.localScale += _scaleSpeed * new Vector3(1, 1, 1) * Time.deltaTime;
    }
}
