using System;

namespace Code.Infrastructure
{
    public interface IUpdateable
    {
        event Action Updating;
    }
}
