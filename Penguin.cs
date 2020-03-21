using UnityEngine;
public class Penguin : MonoBehaviour
{
    private bool m_IsQuitting;

    void OnEnable()
    {
        EventBus.StartListening("PenguinSpawn", PenguinSpawn);
    }

    void OnApplicationQuit()
    {
        m_IsQuitting = true;
    }

    void OnDisable()
    {
        if (m_IsQuitting == false)
        {
            EventBus.StopListening("PenguinSpawn", PenguinSpawn);
        }
    }

    void PenguinSpawn()
    {
        Debug.Log("Spawned Penguin");
        Instantiate(Resources.Load("Penguin"));
    }
}