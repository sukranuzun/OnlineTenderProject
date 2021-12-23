﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult Add(Admin admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Admin>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Admin> GetById(int adminId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.Updated);
        }
    }
}
