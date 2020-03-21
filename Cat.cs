using UnityEngine;
public class Cat : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("CatSpawn", CatSpawn);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("CatSpawn", CatSpawn);
        }
    }

    void CatSpawn()
    {
        Debug.Log("Spawned Cat");
        Instantiate(Resources.Load("Cat"));
    }
}