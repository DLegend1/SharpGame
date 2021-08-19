using SharpGame.Entities;
using SharpGame.Helpers.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpGame.Helpers.Builders {
    public class MonsterBuilder {
        private Monster monster { get; set; }

        public MonsterBuilder()
        {
            this.monster = new Monster();
        }

        public Monster Build()
        {
            return this.monster;
        }

        public MonsterBuilder WithName(string name)
        {
            this.monster.Name = name;
            return this;
        }

        public MonsterBuilder WithHealth(int maxHealth)
        {
            this.monster.Health = new Resource { Name = "Health", Current = maxHealth, Max = maxHealth } ;
            return this;
        }

        public MonsterBuilder WithEnergy(int maxEnergy)
        {
            this.monster.Energy = new Resource { Name = "Energy", Current = maxEnergy, Max = maxEnergy};
            return this;
        }

        public MonsterBuilder WithLevel(int level)
        {
            this.monster.Level = level;
            return this;
        }

        public MonsterBuilder WithCoins(int coins)
        {
            this.monster.Coins = coins;
            return this;
        }

        public MonsterBuilder WithStats(Stats stats)
        {
            this.monster.Stats = stats;
            return this;
        }

        public MonsterBuilder WithWeapon(Weapon weapon)
        {
            weapon.Attach(this.monster);
            return this;
        }

        public MonsterBuilder WithPotions(Dictionary<string, Potion> potions)
        {
            this.monster.Potions = potions;
            return this;
        }

        public MonsterBuilder WithAbilities(List<Ability> abilities)
        {
            this.monster.Abilities = abilities;
            return this;
        }

        public MonsterBuilder WithBuffs(List<Buff> buffs)
        {
            this.monster.Buffs = buffs;
            return this;
        }

        public MonsterBuilder WithBehavior(MonsterBehavior behavior)
        {
            this.monster.Behavior = behavior;
            return this;
        }

        public MonsterBuilder WithAttackTrigger(EventHandler<CombatEventArgs> onAttack)
        {
            this.monster.OnAttack += onAttack;
            return this;
        }

        public MonsterBuilder WithDamageTrigger(EventHandler<CombatEventArgs> onDamage)
        {
            this.monster.OnTakingDamage += onDamage;
            return this;
        }

        public MonsterBuilder WithDeathTrigger(EventHandler onDeath)
        {
            this.monster.OnDeath += onDeath;
            return this;
        }

        public MonsterBuilder WithTargetTrigger(EventHandler onTargeted)
        {
            this.monster.OnTargeted += onTargeted;
            return this;
        }

        public MonsterBuilder WithTurnStartTrigger(EventHandler onTurnStart)
        {
            this.monster.OnTurnStart += onTurnStart;
            return this;
        }

        public MonsterBuilder WithTurnEndTrigger(EventHandler onTurnEnd)
        {
            this.monster.OnTurnEnd += onTurnEnd;
            return this;
        }

        public MonsterBuilder WithRoundStartTrigger(EventHandler onRoundStart)
        {
            this.monster.OnRoundStart += onRoundStart;
            return this;
        }

        public MonsterBuilder WithItemUseTrigger(EventHandler onUseItem)
        {
            this.monster.OnUseItem += onUseItem;
            return this;
        }
    }
}
