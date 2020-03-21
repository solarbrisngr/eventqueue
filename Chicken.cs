using UnityEngine;
public class Chicken : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("ChickenSpawn", ChickenSpawn);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("ChickenSpawn", ChickenSpawn);
        }
    }

    void ChickenSpawn()
    {
        Debug.Log("Spawned Chicken");
        Instantiate(Resources.Load("Chicken"));
    }
}