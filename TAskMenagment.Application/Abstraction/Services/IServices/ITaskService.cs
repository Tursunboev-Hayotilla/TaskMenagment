﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskMenagment.Domain.Entities.DataTransferObject;
using TaskMenagment.Domain.Entities.Model;
using TaskMenagment.Domain.Entities.ViewModels;

namespace TaskMenagment.Application.Abstraction
{
    public interface ITaskService
    {
        public Task<ProgTask> Create(ProgTaskDTO entity);
        public Task<ProgTask> GetById(int id);
        public Task<IEnumerable<ProgTask>> GetAll();
        public Task<bool> Delete(Expression<Func<ProgTask, bool>> expression);
        public Task<ProgTask> Update(ProgTaskDTO entity,int id);
    }
}
