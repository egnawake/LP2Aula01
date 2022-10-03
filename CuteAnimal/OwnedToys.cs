using System;

namespace CuteAnimal
{
    [Flags]
    public enum OwnedToys
    {
        None = 0,
        Mouse = 1 << 0,
        Ball = 1 << 1,
        Fish = 1 << 2,
        Bird = 1 << 3
    }
}

