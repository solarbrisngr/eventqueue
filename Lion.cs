using UnityEngine;
public class Lion : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("LionSpawn", LionSpawn);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("LionSpawn", LionSpawn);
        }
    }

    void LionSpawn()
    {
        Debug.Log("Spawned Lion");
        Instantiate(Resources.Load("Lion"));
    }
}