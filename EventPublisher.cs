using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            EventBus.AddToQueue("DogSpawn");
        }

        if (Input.GetKeyDown("2"))
        {
            EventBus.AddToQueue("CatSpawn");
        }

        if (Input.GetKeyDown("3"))
        {
            EventBus.AddToQueue("ChickenSpawn");
        }

        if (Input.GetKeyDown("4"))
        {
            EventBus.AddToQueue("LionSpawn");
        }

        if (Input.GetKeyDown("5"))
        {
            EventBus.AddToQueue("PenguinSpawn");
        }
    }
}