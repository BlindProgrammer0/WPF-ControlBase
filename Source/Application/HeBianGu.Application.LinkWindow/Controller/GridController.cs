﻿using HeBianGu.Base.WpfBase;
using HeBianGu.General.WpfControlLib;
using HeBianGu.General.WpfMvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeBianGu.Application.LinkWindow
{
    [Route("Grid")]
    class GridController: Controller
    {
        public async Task<IActionResult> GridCenter()
        {
            return await ViewAsync();
        }

    }
}
