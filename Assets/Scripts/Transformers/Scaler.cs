using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale += _scaleSpeed * Vector3.one * Time.deltaTime;
    }
}
