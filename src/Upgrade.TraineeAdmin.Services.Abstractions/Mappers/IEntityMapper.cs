using System.Collections.Generic;
using Sdk.Domain.Models;

namespace Upgrade.TraineeAdmin.Services.Abstractions.Mappers
{
     public interface IEntityMapper<TEntity>
          where TEntity : Entity

     {
          TDto ToDto<TDto>(TEntity entity);

          List<TDto> ToDto<TDto>(List<TEntity> entity);

          TEntity ToEntity<TDto>(TDto dto);

          List<TEntity> ToEntity<TDto>(List<TDto> dto);
     }
}