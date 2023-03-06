using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Commands
{
    public record InserPersonCommand(string FirstName, string LastName) : IRequest<PersonModel>;
    //public class InserPersonCommandClass :  IRequest<PersonModel>
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public InserPersonCommandClass(string firstName, string lastName)
    //    {
    //        FirstName = firstName;
    //        LastName = lastName;
    //    }
    //}
}
