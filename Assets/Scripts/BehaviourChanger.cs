using UnityEngine;
using UnityEngine.InputSystem;

public class BehaviourChanger : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    void Start()
    {
        Debug.Log($"Hello cube!");
    }

    void Update()
    {
        
    }

    public void Fire(InputAction.CallbackContext callback)
    {
        if (callback.action.phase == InputActionPhase.Performed)
            ChangeColor(cube);
    }

    public void Reload(InputAction.CallbackContext callback)
    {
        if (callback.action.phase == InputActionPhase.Performed)
            RotateObject(cube);
    }

    public void Jump(InputAction.CallbackContext callback)
    {
        if (callback.action.phase == InputActionPhase.Performed)
            Jump(cube.GetComponent<Rigidbody>());
    }

    private void ChangeColor(GameObject obj)
    {
        obj.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
    }

    private void RotateObject(GameObject obj)
    {
        obj.transform.Rotate(obj.transform.position, Random.value * 100f);
    }

    private void Jump(Rigidbody obj)
    {
        obj.AddForce(Vector3.up * 400f);
    }
}
