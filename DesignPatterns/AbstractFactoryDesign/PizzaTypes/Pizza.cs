using DesignPatterns.AbstractFactoryDesign.Interfaces;

namespace DesignPatterns.AbstractFactoryDesign
{
    public abstract class Pizza
    {
        private string name = "Pizza";
        protected IPizzaIngredientFactory pizzaInGredientFactory;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string Getname()
        {
            return name;
        }
        public abstract void Prepare();

        public void Bake()
        {
            System.Console.WriteLine("Bake for 25 min at 350"); ;
        }
        public void Cut()
        {
            System.Console.WriteLine("Cutting the pizza");
        }
        public void Box()
        {
            System.Console.WriteLine("Place the pizza in box");
        }

    }
}