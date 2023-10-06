using System.Collections;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObjects;

    private void Start()
    {
        StartCoroutine(Creating());
    }

    private IEnumerator Creating()
    {
        float dryingTimer = 2f;
        bool IsBeingCreated = true;

        while (IsBeingCreated)
        {
            float minValue = -10f;
            float maxValue = 10f;
            float positionY = Random.Range(minValue, maxValue);
            float positionX = Random.Range(minValue, maxValue);

            int index = Random.Range(0, _gameObjects.Length - 1);

            Instantiate(_gameObjects[index], new Vector3(positionY, 0f, positionX), Quaternion.identity);
            yield return new WaitForSeconds(dryingTimer);
        }
    }
}
