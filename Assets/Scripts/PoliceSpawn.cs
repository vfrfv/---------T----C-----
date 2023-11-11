using System.Collections;
using UnityEngine;

public class PoliceSpawn: MonoBehaviour
{
    [SerializeField] private Police _police;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private Racer[] _racer;

    private void Start()
    {
        StartCoroutine(Creating());
    }

    private IEnumerator Creating()
    {
        float dryingTimer = 3f;
        bool IsBeingCreated = true;
        var delaySpawn = new WaitForSeconds(dryingTimer);

        while (IsBeingCreated)
        {
            int randomRacer = Random.Range(0, _racer.Length);
            int randomPoint = Random.Range(0, _spawnPoints.Length);

            Police police = Instantiate(_police, _spawnPoints[randomPoint].position, Quaternion.identity);

            police.Initialize(_racer[randomRacer]);

            yield return delaySpawn;
        }
    }
}
