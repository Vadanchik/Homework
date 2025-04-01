using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Cube : MonoBehaviour
{
    [SerializeField] private CubeCreator _cubeCreator;
    [SerializeField] private ParticleSystem _effect;

    private float _explosionRadius = 2;
    private float _explosionForce = 5;
    private float _divisionChance = 1.0f;

    public void SetScale(Vector3 scale)
    {
        transform.localScale = scale;
    }

    public void SetDivisionChance(float chance)
    {
        _divisionChance = chance;
    }

    public void SetCubeCreator(CubeCreator cubeCreator)
    {
        _cubeCreator = cubeCreator;
    }

    private void OnMouseDown()
    {
        float chance = Random.value;

        if (chance < _divisionChance)
        {
            _cubeCreator.CreateCube(transform.position, transform.localScale, _divisionChance);
            Explode();
        }

        Destroy(gameObject);
    }

    private void Explode()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius * transform.localScale.magnitude);

        foreach (Collider hit in hits)
        {
            if (hit.transform.TryGetComponent(out Cube cube))
            {
                Vector3 direction = (cube.transform.position - transform.position).normalized;
                cube.GetComponent<Rigidbody>().AddForce(direction * _explosionForce, ForceMode.Impulse);
            }
        }

        Instantiate(_effect, transform.position, Quaternion.identity).transform.localScale = transform.localScale;
    }
}
