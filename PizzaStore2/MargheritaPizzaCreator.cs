namespace PizzaStore2
{
    internal class MargheritaPizzaCreator : PizzaCreator
    {
        public override IPizza CreatePizza()
        {
            return new MargheritaPizza();
        }
    }
}
