﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdateMe.Data.Models;

namespace UpdateMe.Services.Contracts
{
    public interface IAssignmentServices
    {
        IEnumerable<Assignment> ListAllAssignmentsFromUser(string userName);
    }
}