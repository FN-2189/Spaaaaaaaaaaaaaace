using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCone : PowerModule
{
    [Header("Drive Cone")]
    [SerializeField]
    private Reactor reactor;
    [SerializeField]
    private Thruster driveCone;
    [SerializeField]
    private float maxDriveConeConsumption;

    void Start()
    {
        
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
        reactor.driveconeConsumption = maxDriveConeConsumption * driveCone.thrustLevel;
    }

}