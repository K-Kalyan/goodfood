using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Dtos;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IIngredientGenerator
    {
        Task<bool> Create(int userId, Ingredients recipe);
        Task<bool> IsIngredientExits(string IngredientName, int userId);
        Task<List<IngredientDto>> GetIngredients(int userId);
        Task<IngredientDto> GetIngredient(int userId, int ingredientId);
        Task<bool> Update(int userId, int ingredientId, IngredientDto ingredient);
    }
}