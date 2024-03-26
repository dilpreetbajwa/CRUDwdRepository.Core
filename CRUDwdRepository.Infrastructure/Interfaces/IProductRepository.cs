using System;
using CRUDwdRepository.Core;

namespace CRUDwdRepository.Infrastructure.Interfaces
{
	public interface IProductRepository
    {

		Task<IEnumerable<Product>> GetAll();

		Task<Product> GetById(int id);

        Task Add(Product model);

		Task Update(Product model);

        Task Delete(int id);
	}
}

