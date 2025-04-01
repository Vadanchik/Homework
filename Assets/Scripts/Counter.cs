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
            StopCoroutine(_countCoroutine);
            _isCount = false;
        }
        else
        {
            _countCoroutine = StartCoroutine(Count());
            _isCount = true;
        }
    }

    private void CountView()
    {
        _counterText.text = _currentCount.ToString();
    }

    private IEnumerator Count()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(_delay);

            _currentCount++;
            CountView();
        }
    }
}
