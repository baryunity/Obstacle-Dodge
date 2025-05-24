using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeToWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRigidBody;

    private void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myRigidBody = GetComponent<Rigidbody>();
        myMeshRenderer.enabled = false;
        myRigidBody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {

        }
    }
}
