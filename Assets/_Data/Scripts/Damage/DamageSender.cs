using UnityEngine;

public class DamageSender : SaiMonoBehaviour
{
    [SerializeField] protected double damage = 1;

    public virtual void Send(Transform obj)
    {
        DamagerReceiver damageReceiver = obj.GetComponentInChildren<DamagerReceiver>();
        if (damageReceiver == null) return;
        this.Send(damageReceiver);
        CreateImpactFX();
    }

    protected void CreateImpactFX()
    {
        string fxName = GetImpactName();

        Transform fx = FXSpawner.Instance.Spawn(fxName, transform.position, transform.rotation);
        fx.gameObject.SetActive(true);
    }

    protected string GetImpactName()
    {
        return FXSpawner.impact1;
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
