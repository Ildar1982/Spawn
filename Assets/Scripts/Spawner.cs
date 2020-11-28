using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;

    private WaitForSeconds waitForTwoSeconds = new WaitForSeconds(2f);
    private int numberPoints;

    private void Start()
    {
        StartCoroutine(Spawn());
    }
    private IEnumerator Spawn()
    {         
        while (true)
        {
            numberPoints = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[numberPoints]);
            yield return waitForTwoSeconds;
        }
    }
}
