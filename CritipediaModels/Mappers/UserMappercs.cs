using CritipediaModels.DTOs;
using Entities;

namespace CritipediaModels.Mappers
{
    public static class UserMappercs
    {
        public static UserDTO Map(User u)
        {
            UserDTO returnDto = new UserDTO();
            returnDto.Name = u.Nombre;
            returnDto.Surname = u.Apellidos;
            returnDto.Email = u.Email;
            returnDto.Age = u.Edad;
            returnDto.Phone = u.Telefono;

            return returnDto;
        }
    }
}
