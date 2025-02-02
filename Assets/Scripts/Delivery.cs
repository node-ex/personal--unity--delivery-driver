using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] bool _hasPackage = false;
    [SerializeField] Color32 _hasNoPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 _hasPackageColor = new Color32(255, 255, 255, 255);
    [SerializeField] float _packageDisappearanceDelayInSeconds = 3.0f;

    SpriteRenderer _spriteRenderer;

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // if (collider.gameObject.CompareTag("Package"))
        if (collider.tag == "Package" && !_hasPackage)
        {
            Debug.Log("Package picked up!");
            _hasPackage = true;
            Destroy(collider.gameObject, _packageDisappearanceDelayInSeconds);
            _spriteRenderer.color = _hasPackageColor;
        }
        if (collider.tag == "Customer" && _hasPackage)
        {
            Debug.Log("Package delivered!");
            _hasPackage = false;
            _spriteRenderer.color = _hasNoPackageColor;
        }
    }
}
