using UnityEngine;

public class AroundRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        transform.Rotate(_rotateSpeed * Vector3.up * Time.deltaTime);
    }
}
