
using UnityEngine;
using UnityEngine.EventSystems;

public class Goals : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    public AudioClip ping;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(ping, transform.position);
        }
    }
    
    

}
