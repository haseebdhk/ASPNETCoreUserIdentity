﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreUserIdentity.Models.ManageViewModels
{
    public class GenerateRecoveryCodesViewModel
    {
        public string[] RecoveryCodes { get; set; }
    }
}
