using UnityEngine;

public class DamageSender : SaiMonoBehaviour
{
    [SerializeField] protected double damage = 1;

    public virtual void Send(Transform obj)
    {
        DamagerReceiver damageReceiver = obj.GetComponentInChildren<DamagerReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
    }

    public virtual void Send(DamagerReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }


    public virtual void SetDamage(double damage)
    {
        this.damage = damage;
    }

    public virtual void DestroyObj()
    {
        Destroy(transform.parent.gameObject);
    }
}
