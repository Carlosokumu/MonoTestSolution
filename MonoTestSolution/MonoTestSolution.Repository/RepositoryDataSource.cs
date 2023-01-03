using AutoMapper;
using MonoTestSolution.Repository.interfaces;
using MonoTestSolution.Repository.models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace MonoTestSolution.Repository
{
    public class RepositoryDataSource
    {

        private SQLiteAsyncConnection _connection;
       

        public RepositoryDataSource(SQLiteAsyncConnection connection,IRepositoryMockDataApi irepositoryMockDataApi,IMapper imapper)
        {
            _connection = connection;
                   
            //Create a Table  For VehicleMakeEntity and VehicleModelEntity
            _connection.CreateTableAsync<VehicleMakeEntity>();
            _connection.CreateTableAsync<VehicleModelEntity>();
            _connection.CreateTableAsync<VehicleMakeDetailsEntity>();

        }
         
        
    }
}
