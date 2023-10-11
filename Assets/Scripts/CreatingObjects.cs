using System.Collections;
using UnityEngine;

public class CreatingObjects : MonoBehaviour
{
    [SerializeField] private CarMovement[] _cars;
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
            int index = Random.Range(0, _cars.Length - 1);
            int randomPoint = Random.Range(0, _spawnPoints.Length);

            Instantiate(_cars[index], _spawnPoints[randomPoint].position, Quaternion.identity);

            yield return delaySpawn;
        }
    }
}
