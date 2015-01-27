﻿namespace R.MessageBus.Interfaces
{
    public interface IProcessManagerFinder
    {
        IPersistanceData<T> FindData<T>(IProcessManagerPropertyMapper mapper, Message message) where T : class, IProcessManagerData;

        void InsertData(IProcessManagerData data);
        void UpdateData<T>(IPersistanceData<T> data) where T : class, IProcessManagerData;
        void DeleteData<T>(IPersistanceData<T> data) where T : class, IProcessManagerData;
    }
}
