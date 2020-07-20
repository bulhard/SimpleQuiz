﻿using AutoMapper;

namespace SimpleQuiz.Common.Models
{
    public interface IMapFrom<T>
    {
        void Mapping(Profile mapper) => mapper.CreateMap(typeof(T), this.GetType());
    }
}