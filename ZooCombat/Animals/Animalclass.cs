using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooCombat.Animals
{
    internal class ClsAnimal
    {
        string animalName;
        int animalHP, animalAP, animalSpeed, animalAttack;

        public ClsAnimal(string animalName, int animalHP, int animalAP, int animalSpeed, int animalAttack)
        {
            this.animalName = animalName;
            this.animalHP = animalHP;
            this.animalAP = animalAP;
            this.animalSpeed = animalSpeed;
            this.animalAttack = animalAttack;
        }
    }
}
