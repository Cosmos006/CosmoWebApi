﻿using DomainLayer.EntityModels.ListModels;
using DomainLayer.EntityModels.Procedures;
using DomainLayer.Models;
using RepositoryLayer;
using RepositoryLayer.Interfaces;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServiceLayer
{
    public class UserService : IUserService
    {
        private IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public void RegisterUserData(Registration registration)
        {
            _repository.AddUser(registration);
          
        }
        public List<UserInfoDetails> GetUserData()
        {
            List<UserInfoDetails> userDetails = _repository.GetUser();
            return userDetails;
        }
    }
}
