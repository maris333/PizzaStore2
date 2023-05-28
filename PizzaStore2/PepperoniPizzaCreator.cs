namespace PizzaStore2
{
    internal class PepperoniPizzaCreator : PizzaCreator
    {
        public override IPizza CreatePizza()
        {
            return new PepperoniPizza();
        }
    }
}
