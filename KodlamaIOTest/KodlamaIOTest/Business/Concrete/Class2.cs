﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities5.Concrete;
using KodlamaIOTest.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.Get(id);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        List<Course> ICourseService.GetAll()
        {
            throw new NotImplementedException();
        }

        Course ICourseService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}