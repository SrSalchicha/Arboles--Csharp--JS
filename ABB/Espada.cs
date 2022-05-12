using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABB
{
    internal class Espada : IComparable<Espada>
    {

        private string name;
        private int damage;
        private string description;

        //Datos encapsulados 
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Damage { get => damage; set => damage = value; }

        //Constructor Espada
        public Espada(string name, string description, int damage)
        {
            Name = name;
            Description = description;
            Damage = damage;
        }

        public Espada(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public int CompareTo(Espada e)
        {
            return Damage.CompareTo(e.Damage);
        }

        public override string ToString()
        {
            return Environment.NewLine + " Nombre: " + Name + Environment.NewLine
                + " Descripcion:  " + Description + Environment.NewLine 
                + " Damage: " + Damage + Environment.NewLine; 
        }
    }
}
