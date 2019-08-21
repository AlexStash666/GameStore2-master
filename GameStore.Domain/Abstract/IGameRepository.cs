using System;
using System.Collections.Generic;
using System.Text;
using GameStore.Domain.Entities;
using GameStore.Domain.Abstract;


namespace GameStore.Domain.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Games { get; }
    }
}
