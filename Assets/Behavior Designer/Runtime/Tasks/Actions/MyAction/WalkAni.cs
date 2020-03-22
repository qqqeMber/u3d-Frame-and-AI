using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("播放walk")]
public class WalkAni : Action
{
    [BehaviorDesigner.Runtime.Tasks.Tooltip("动画器")]
    public Animator animator;
    [BehaviorDesigner.Runtime.Tasks.Tooltip("当前动画状态")]
    public AnimatorStateInfo info;
    public override TaskStatus OnUpdate()
    {
        info = animator.GetCurrentAnimatorStateInfo(0);
        if (info.IsName("Attack"))
        {
            animator.SetBool("isATTACK", false);
        }
        else if (info.IsName("Idle"))
        {
            animator.SetBool("isIDLE", false);
        }
        else if (info.IsName("Run"))
        {
            animator.SetBool("isRUN", false);
        }
        animator.SetBool("isWALK", true);
        return TaskStatus.Success;
    }
}

