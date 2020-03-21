using UnityEngine;
public class Dog : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("DogSpawn", DogSpawn);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("DogSpawn", DogSpawn);
        }
    }

    void DogSpawn()
    {
        Debug.Log("Spawned Dog");
        Instantiate(Resources.Load("Dog"));
    }
}