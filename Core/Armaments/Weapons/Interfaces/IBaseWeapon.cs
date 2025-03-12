using Core.Combat.Models;

namespace Core.Armaments.Weapons.Interfaces;

public interface IBaseWeapon
{
    int       MinDamage         { get; set; }
    int       MaxDamage         { get; set; }
    float     KnockbackForce    { get; set; }
    HitResult FinalDamage       { get; }
    float     SwingCooldown     { get; set; }
    bool      DealsSplashDamage { get; set; }
    float     SplashDamage      { get; set; }
    float     Speed             { get; set; }
}