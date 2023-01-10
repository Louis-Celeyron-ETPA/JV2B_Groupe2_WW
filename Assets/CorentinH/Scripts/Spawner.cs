using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HARDYCorentin
{
    public class Spawner : MonoBehaviour
    {

        public GameObject objectToSpawn;
        public Transform parent;
        public float minTime = 0f;
        public float maxTime;
        public float currentTime;
        // Start is called before the first frame update
        void Start()
        {


        }

        // Update is called once per frame
        void Update()
        {

            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                Instantiate(objectToSpawn, parent);
                currentTime = Random.Range(minTime, maxTime);
            }
        }
    }
}