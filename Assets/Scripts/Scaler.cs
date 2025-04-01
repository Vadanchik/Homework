using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.localScale += _scaleSpeed * Vector3.one * Time.deltaTime;
    }
}
