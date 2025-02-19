﻿
using Domain.Entities.Productos;

namespace AppCore.Interfaces
{
    public interface IService<T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        T[] FindAll();
        int GetLastId();
        void Add(T t, ref T[] data);
    }
}