using JeeroBakery.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JeeroBaker.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Gets all of this type in the database
        /// </summary>
        /// <returns>IEnumerable of type T</returns>
        public IEnumerable<T> GetAll();
        /// <summary>
        /// Gets an instance of type T using the supplied ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Instance of type T</returns>
        public T GetById(int id);
        /// <summary>
        /// Updates the entity 
        /// </summary>
        /// <param name="entity">The entity to be updated</param>
        /// <returns>The modified entity</returns>
        public T Update(T entity);
        /// <summary>
        /// Removes an entity from the persistence medium
        /// </summary>
        /// <param name="id">The id of the entity to be deleted</param>
        /// <returns></returns>
        public T Delete(int id);
        /// <summary>
        /// For paging the records for performance reasons
        /// </summary>
        /// <param name="startPage">The start page</param>
        /// <param name="count">The number of records to return</param>
        /// <returns></returns>
        public IEnumerable<T> Page(int startPage, int count = 50);
        /// <summary>
        /// Returns the total number of this entity type in the data store
        /// </summary>
        /// <returns></returns>
        public int Count();
        /// <summary>
        /// Persists an instance of the entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>An instance of the newly created entity</returns>
        public T Add(T entity);
    }
}