﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KailashEngine.Client;
using KailashEngine.Output;

namespace KailashEngine.Render.FX
{
    abstract class RenderEffect
    {

        protected ProgramLoader _pLoader;
        protected string _path_glsl_effect;

        protected Resolution _resolution_full;


        public RenderEffect(ProgramLoader pLoader, string glsl_effect_path, Resolution full_resolution)
        {
            _pLoader = pLoader;
            _path_glsl_effect = glsl_effect_path;
            _resolution_full = full_resolution;

            load_Programs();
        }

        protected abstract void load_Programs();

        public abstract void load();

        public abstract void unload();

        public abstract void reload();
    }
}