﻿using System;

namespace UdemyDependency.Services
{
    public class TransientManager : ITransientService
    {
        private string _guidId;
        public TransientManager()
        {
            _guidId =Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
    public class ScopeManager : IScopedService
    {
        private string _guidId;
        public ScopeManager()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
    public class SingletonManager : ISingletonService
    {
        private string _guidId;
        public SingletonManager()
        {
            _guidId = Guid.NewGuid().ToString();
        }
        public string GuidId => _guidId;
    }
}
