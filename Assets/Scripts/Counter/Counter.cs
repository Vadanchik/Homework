using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private TMP_Text _counterText;
    [SerializeField] private float _delay = 0.5f;

    private int _currentCount;

    private Coroutine _countCoroutine;

    private bool _isCount = false;


    public void ButtonClick()
    {
        if (_isCount)
        {
            _isCount = false;
            StopCoroutine(_countCoroutine);
        }
        else
        {
            _isCount = true;
            _countCoroutine = StartCoroutine(Count());
        }
    }

    private void CountView()
    {
        _counterText.text = _currentCount.ToString();
    }

    private IEnumerator Count()
    {
        while (_isCount)
        {
            yield return new WaitForSeconds(_delay);

            _currentCount++;
            CountView();
        }
    }
}
