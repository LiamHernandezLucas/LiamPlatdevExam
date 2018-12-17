using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour {

    [SerializeField]
    float _interval;

    [SerializeField]
    GameObject _prefab;

    float _timer;

    void Update()
    {
        Spawn();
    }

    void Spawn()
    {
        _timer += Time.deltaTime;
        if (_timer >= _interval)
        {
            GameObject item;
            item = Instantiate(_prefab, this.transform);
            _timer = 0;
        }
    }

}
