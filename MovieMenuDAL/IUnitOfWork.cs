﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IMovieRepository MovieRepository { get; }
        int Complete();
    }
}