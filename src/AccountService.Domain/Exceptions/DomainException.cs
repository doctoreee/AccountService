using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountService.Domain.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException(ExceptionModel model, dynamic data = null) : base(model.Message)
        {
            Model = model;
            Model.Data = data;
        }

        public ExceptionModel Model { get; }
    }
}
