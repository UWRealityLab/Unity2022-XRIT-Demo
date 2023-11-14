using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.XR.Interaction.Toolkit;

public class ControllerProjectileSpawner : MonoBehaviour
{
    public InputActionReference rightHandActivateReference = null;
    public GameObject projectile;
    public float initialVelocity;
    public Vector3 spawnPointOffset;
    /*
    private void Awake()
    {
        rightHandActivateReference.action.performed += SpawnProjectile;
    }

    private void OnDestroy()
    {
        rightHandActivateReference.action.performed -= SpawnProjectile;
    }
    */
    public void SpawnProjectile()
    {
        var spawnedProjectile = Instantiate(projectile, transform.position + transform.rotation * spawnPointOffset, transform.rotation);
        var rb = spawnedProjectile.GetComponent<Rigidbody>();
        rb.velocity = spawnedProjectile.transform.forward * initialVelocity;
    }
}
