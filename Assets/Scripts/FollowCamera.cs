using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    const float SLIGHTLY_MOVED_Z_POSITION = -10.0f;
    [SerializeField] GameObject _objectToFollow = null;

    /*
     * Placing camera following logic here makes sure camera moves smoothly
     */
    void LateUpdate()
    {
        transform.position = _objectToFollow.transform.position + new Vector3(0, 0, SLIGHTLY_MOVED_Z_POSITION);
    }
}
