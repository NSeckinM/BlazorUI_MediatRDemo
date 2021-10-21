using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    // record and class equivalent except the fact that a record has the additional syntax and goodness
    // that records provide such as beign immutable by default

    //public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    //{

    //}

    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

}
