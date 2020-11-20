using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondsBetweenSpawn;

    private float _elapsedTime;
    
    void Update()
    {
        _elapsedTime += Time.deltaTime;        
        if (_elapsedTime >= _secondsBetweenSpawn)
        {
            _elapsedTime = 0;
            int numberPoints = Random.Range(0, _spawnPoints.Length);
            Instantiate(_enemy, _spawnPoints[numberPoints]);
        }
    }
}
