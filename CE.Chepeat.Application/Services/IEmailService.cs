﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Chepeat.Application.Services;
public interface IEmailService
{
    Task SendEmailAsync(string to, string subject, string templateName, object model);
}
