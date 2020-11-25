using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;

    private void Start()
    {
        StartCoroutine(InitSpawn());
    }
    private IEnumerator InitSpawn()
    {
        WaitForSeconds waitForTwoSeconds = new WaitForSeconds(2f);
        while (true)
        {
            int numberPoints = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[numberPoints]);
            yield return waitForTwoSeconds;
        }
    }
}
