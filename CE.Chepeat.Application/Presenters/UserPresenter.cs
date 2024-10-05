﻿using CE.Chepeat.Domain.Aggregates.User;

namespace CE.Chepeat.Application.Presenters;
public class UserPresenter : IUserPresenter
{
    private readonly IUnitRepository _unitRepository;
    private readonly IMapper _mapper;

    public UserPresenter(IUnitRepository unitRepository, IMapper mapper)
    {
        _unitRepository = unitRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Consulta un registro de la tabla CE_Users
    /// </summary>
    /// <returns></returns>
    public async Task<List<UserDto>> GetUsers()
    {
        return await _unitRepository.userInfraestructure.GetUsers();
    }

    /// <summary>
    /// Agregar un registro a Users
    /// </summary>
    /// <returns></returns>
    public async Task<RespuestaDB> AddUser(UserAggregate userAggregate)
    {
        //var lista = new Lista();
        //var respuestaDB = new RespuestaDB();
        //respuestaDB.Lista.Add(new Lista { Apellido = 'Nombre', Nombre = 'Nombrso' });
        return await _unitRepository.userInfraestructure.AddUser(userAggregate);
    }

    /// <summary>
    /// Agregar un registro a Users
    /// </summary>
    /// <returns></returns>
    public async Task<RespuestaDB> DeleteUser(Guid id)
    {
        //var lista = new Lista();
        //var respuestaDB = new RespuestaDB();
        //respuestaDB.Lista.Add(new Lista { Apellido = 'Nombre', Nombre = 'Nombrso' });
        return await _unitRepository.userInfraestructure.DeleteUser(id);
    }

    /// <summary>
    /// Agregar un registro a Users
    /// </summary>
    /// <returns></returns>
    public async Task<RespuestaDB> UpdateUser(UserAggregate userAggregate)
    {
        //var lista = new Lista();
        //var respuestaDB = new RespuestaDB();
        //respuestaDB.Lista.Add(new Lista { Apellido = 'Nombre', Nombre = 'Nombrso' });
        return await _unitRepository.userInfraestructure.UpdateUser(userAggregate);
    }
}