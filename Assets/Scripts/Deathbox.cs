using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
public class Deathbox : MonoBehaviour
{
    public UnityEvent onTrigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTrigger.Invoke();
    }
}
