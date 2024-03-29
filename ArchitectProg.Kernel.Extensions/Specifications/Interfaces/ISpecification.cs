﻿namespace ArchitectProg.Kernel.Extensions.Specifications.Interfaces;

public interface ISpecification<T>
{
    IQueryable<T> AddEagerFetching(IQueryable<T> query);
    IQueryable<T> AddPredicates(IQueryable<T> query);
    IQueryable<T> AddSorting(IQueryable<T> query);
}