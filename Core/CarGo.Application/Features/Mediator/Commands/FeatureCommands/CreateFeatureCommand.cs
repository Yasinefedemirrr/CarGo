﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace CarGo.Application.Features.Mediator.Commands.FeatureCommands
{
    public class CreateFeatureCommand:IRequest
    {
       public string Name { get; set; }
   
    }
}
