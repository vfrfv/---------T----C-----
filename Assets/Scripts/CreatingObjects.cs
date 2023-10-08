using System.Collections;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] _gameObjects;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(Creating());
    }

    private IEnumerator Creating()
    {
        float dryingTimer = 2f;
        bool IsBeingCreated = true;
        var delaySpawn = new WaitForSeconds(dryingTimer);

        while (IsBeingCreated)
        {
            int index = Random.Range(0, _gameObjects.Length - 1);
            int randomPoint = Random.Range(0, _spawnPoints.Length);

            Instantiate(_gameObjects[index], _spawnPoints[randomPoint].position, Quaternion.identity);

            yield return delaySpawn;
        }
    }
}
