using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void LateUpdate()
    {
        if(player !=null)
        {
         transform.position = target.position + offset;

        }
    }

    /* [SerializeField] private GameObject player;
     [SerializeField] private Vector3 offset;
     [SerializeField] private float smoothness;

    //Kamera ei tällä hetkellä seuraa pelaajaa for no reason. TÄMÄ SKRIPTIOSUUS EI TOIMINUT!!//
     private void Update()
     {
         transform.position = Vector3.Lerp(transform.position, player.transform.position + offset, smoothness);
     }*/

}
