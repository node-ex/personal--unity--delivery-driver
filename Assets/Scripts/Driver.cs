using UnityEngine;

public class Driver : MonoBehaviour
{
    const float DEFAULT_INPUT_AXIS_MAX_ABSOLUTE_VALUE = 1.0f;

    [SerializeField] float _moveSpeed = 100.0f;
    [SerializeField] float _steerSpeed = 100.0f;

    void Start()
    {
        Debug.Log("Hello World!");
    }

    void Update()
    {
        float moveAmount = Input.GetAxis("Vertical") / DEFAULT_INPUT_AXIS_MAX_ABSOLUTE_VALUE * _moveSpeed;
        transform.Translate(0, moveAmount * Time.deltaTime, 0);

        float reverseSteerAmount = Input.GetAxis("Horizontal") / DEFAULT_INPUT_AXIS_MAX_ABSOLUTE_VALUE * _steerSpeed;
        float steerAmount = -reverseSteerAmount;
        transform.Rotate(0, 0, steerAmount * Time.deltaTime);
    }


    // [SerializeField] float _nearZeroMoveAmount = 0.005f;
    // [SerializeField] float _maxMoveSpeed = 2.0f;
    // [SerializeField] float _minMoveSpeed = -2.0f;
    // [SerializeField] float _moveAmountChange = 0.01f;
    // [SerializeField] float _moveAmount = 0.0f;
    /*
     * How to use in code:
     *
     * float targetMoveSpeed = Input.GetAxis("Vertical") / DEFAULT_INPUT_AXIS_MAX_ABSOLUTE_VALUE * Mathf.Abs(_maxMoveSpeed);
     * _moveAmount = GetSlowlyChangingMoveAmount(_moveAmount, targetMoveSpeed);
     * transform.Translate(0, _moveAmount * Time.deltaTime, 0);
     *
     */
    // float GetSlowlyChangingMoveAmount(float currentMoveAmount, float targetMoveSpeed)
    // {
    //     float newMoveAmount = currentMoveAmount;
    //     if (newMoveAmount < _nearZeroMoveAmount && newMoveAmount > -_nearZeroMoveAmount)
    //     {
    //         newMoveAmount = 0;
    //     }

    //     if (newMoveAmount < targetMoveSpeed && newMoveAmount < _maxMoveSpeed)
    //     {
    //         newMoveAmount += _moveAmountChange;
    //     }
    //     if (newMoveAmount > _maxMoveSpeed)
    //     {
    //         newMoveAmount = _maxMoveSpeed;
    //     }

    //     if (newMoveAmount > targetMoveSpeed && newMoveAmount > _minMoveSpeed)
    //     {
    //         newMoveAmount -= _moveAmountChange;
    //     }
    //     if (_moveAmount < _minMoveSpeed)
    //     {
    //         newMoveAmount = _minMoveSpeed;
    //     }

    //     return newMoveAmount;
    // }
}
