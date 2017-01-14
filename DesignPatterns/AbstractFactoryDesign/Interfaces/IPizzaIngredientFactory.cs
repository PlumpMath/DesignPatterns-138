using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactoryDesign.Interfaces
{
    public interface IPizzaIngredientFactory
    {
        void CreateDough();
        void CreateSauce();
        void CreateChese();
        void CreateVeggies();
        void CreatePepperoni();
        void CreateCalm();
    }
}
