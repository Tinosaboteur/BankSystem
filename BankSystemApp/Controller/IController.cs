using System;
using System.Collections.Generic;

namespace BankSystem.Model
{
    internal interface IController
    {
        List<IModel> Items { get; }
        bool Load();
        bool Create(IModel model);
        bool Update(IModel model);
        bool Delete(Object id);
        IModel Read(Object id);
        bool IsExist(Object id);
        void Search(Object keyWork);
    }
}
