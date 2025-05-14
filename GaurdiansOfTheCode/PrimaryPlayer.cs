using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

//example of singleton pattern

namespace GaurdiansOfTheCode
{
    //we use sealed class so that it cannot be inherited, prevents misuse (behavior can't be changed through inheritance)
    //JIT compiler can optimize calls to sealed classes better bcz it knows the class won't be extended
    //Static class: cannot be instantiated, can only contain static members, is often used to utility or helper methods.
    public sealed class PrimaryPlayer
    {
        private static readonly PrimaryPlayer _instance;
        private PrimaryPlayer(){ }
        
        static PrimaryPlayer(){
            _instance = new PrimaryPlayer()
            {
                Name = "Raptor",
                Level = 1
            };
        }

        public static PrimaryPlayer Instance
        {
            get{
                return _instance;
            }
        }
        public string Name { get; set; }
        public int Level { get; set; }
    }
}