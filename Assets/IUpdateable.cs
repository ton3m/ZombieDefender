using System;

namespace Code
{
    public interface IUpdateable
    {
        event Action Updating;
    }
}
