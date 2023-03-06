using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertPersonHandler : IRequestHandler<InserPersonCommand, PersonModel >
    {
        private readonly IDataAccess _dataAccess;
        public InsertPersonHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public async Task<PersonModel> Handle(InserPersonCommand request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_dataAccess.InsertPerson( request.FirstName, request.LastName));
        }
    }
}
