﻿using DesignPatterns.AbstractFactory.Movements;
using DesignPatterns.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.HeroFactories
{
    // Фабрика создания бегущего героя с мечом
    public class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
