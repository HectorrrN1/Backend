﻿namespace CE.Chepeat.Infraestructure;
public class UnitRepository:BaseDisposable, IUnitRepository
{
    private readonly ChepeatContext _context;
    private readonly IConfiguration _configuration;

    public UnitRepository(ChepeatContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    protected override void DisposeManagedResource()
    {
        try
        {
            _context.Dispose();


            //if (_context.Database.GetDbConnection != null)
            //{
            //    System.Diagnostics.Debug.WriteLine(_context.Database.GetDbConnection().State);
            //    System.Diagnostics.Debug.WriteLine(_context.Database.GetDbConnection().ConnectionTimeout);
            //}
        }
        finally
        {
            base.DisposeManagedResource();
        }
    }
    //
    public IUserInfraestructure userInfraestructure => new UserInfraestructure(_context);
    public IAuthInfraestructure authInfraestructure => new AuthInfraestructure(_context);


    public async ValueTask<bool> Complete()
    {
        return await _context.SaveChangesAsync() > 0;
    }



    public bool HasChanges()
    {
        return _context.ChangeTracker.HasChanges();
    }

}