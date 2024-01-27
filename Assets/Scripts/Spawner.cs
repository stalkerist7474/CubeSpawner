using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefabSpawn;
    [SerializeField] private GameObject _destroyer;
    [SerializeField] private UI UI;
    [SerializeField] private int _spawnCount;
    [SerializeField] private int _destroyRange;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private float _speed;

    private Vector3 _targetPosition;

    private float time;
    private int count;



    private void OnEnable()
    {
        UI.SpeedFieldChanged += ChangeSpeed;
        UI.DictanceFieldChanged += ChangeDictance;
        UI.SpawnTimeFieldChanged += ChangeSpawnTime;

    }


    private void OnDisable()
    {
        UI.SpeedFieldChanged -= ChangeSpeed;
        UI.DictanceFieldChanged -= ChangeDictance;
        UI.SpawnTimeFieldChanged -= ChangeSpawnTime;

    }



    private void Start()
    {
        time = _spawnDelay;
        count = _spawnCount;

        _targetPosition = new Vector3(transform.position.x + _destroyRange, transform.position.y, transform.position.z);

    }

    private void Update()
    {
        if(_prefabSpawn != null)
        {
            time -= Time.deltaTime;

            if(time < 0 && count > 0)
            {
                var obj = Instantiate(_prefabSpawn, transform.position, Quaternion.identity);
                obj.GetComponent<Cube>().StartMove(_targetPosition, _speed);

                count--;
                time = _spawnDelay;
            }
        }
    }


    public void ChangeSpeed(string speed)
    {

        _speed = float.Parse(speed);
    }

    public void ChangeDictance(string distance)
    {

        _destroyRange = int.Parse(distance);
        _destroyer.transform.position = new Vector3( _destroyRange, _destroyer.transform.position.y, _destroyer.transform.position.z);
    }

    public void ChangeSpawnTime(string spawnTime)
    {

        _spawnDelay = float.Parse(spawnTime);
    }



}
