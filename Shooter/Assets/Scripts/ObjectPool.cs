using Geekbrains.Objects;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains
{
    public class ObjectPool : MonoBehaviour
    {
        public GameObject prefab;

        private Stack<GameObject> _inactive = new Stack<GameObject>();

        public GameObject GetObject()
        {
            GameObject spawnedObject;

            if (_inactive.Count > 0)
            {
                spawnedObject = _inactive.Pop();
            }
            else
            {
                spawnedObject = Instantiate(prefab);
                Bullet bullet = spawnedObject.AddComponent<Bullet>();
            }
            spawnedObject.transform.SetParent(null);
            spawnedObject.SetActive(true);

            return spawnedObject;
        }

        public void ReturnObject(GameObject toReturn)
        {
            if (_inactive != null)
            {
                toReturn.transform.SetParent(null);
                toReturn.SetActive(true);
                _inactive.Push(toReturn);
            }
        }
    }

    

}