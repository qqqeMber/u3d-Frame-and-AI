using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using BehaviorDesigner.Runtime;

[TaskCategory("MyActions")]
[TaskDescription("播放run")]
public class RUNAni : Action
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
        else if (info.IsName("Walk"))
        {
            animator.SetBool("isWALK", false);
        }
        else if (info.IsName("Idle"))
        {
            animator.SetBool("isIDLE", false);
        }
        animator.SetBool("isRUN", true);
        return TaskStatus.Success;
    }
}
