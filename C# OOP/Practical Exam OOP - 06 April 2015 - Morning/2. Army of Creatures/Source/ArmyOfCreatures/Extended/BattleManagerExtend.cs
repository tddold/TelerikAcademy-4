﻿
namespace ArmyOfCreatures.Extended
{
    using ArmyOfCreatures.Logic;
    using ArmyOfCreatures.Logic.Battles;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    public class BattleManagerExtend : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        public BattleManagerExtend(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }

        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }

            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            return base.GetByIdentifier(identifier);
        }
    }
}
