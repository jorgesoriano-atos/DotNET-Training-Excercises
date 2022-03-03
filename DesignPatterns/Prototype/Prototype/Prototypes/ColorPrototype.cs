namespace Prototype.Prototypes
{
    public abstract class ColorPrototype
    {
        public abstract ColorPrototype ShallowClone();
        public abstract ColorPrototype DeepClone();
    }
}
