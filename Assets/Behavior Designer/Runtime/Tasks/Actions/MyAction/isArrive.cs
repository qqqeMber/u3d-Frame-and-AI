using UnityEngine.AI;
using UnityEngine;
using System;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyConditionals")]
[TaskDescription("是否到达漫游点")]
public class isArrive : Conditional
{

    [BehaviorDesigner.Runtime.Tasks.Tooltip("移动的目标点")]
    public SharedVector3 position;

    [BehaviorDesigner.Runtime.Tasks.Tooltip("自己")]
    public SharedGameObject monster;
    public override TaskStatus OnUpdate()
    {
        if(Math.Abs(monster.Value.transform.position.x-position.Value.x)<0.1&& Math.Abs(monster.Value.transform.position.z - position.Value.z) < 0.1)
        {
            return TaskStatus.Success;
        }
        return TaskStatus.Failure;
    }
}