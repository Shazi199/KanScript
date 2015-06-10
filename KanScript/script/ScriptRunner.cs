using KanScript.forms;
using NLua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanScript.script
{
    class ScriptRunner
    {
        private Lua lua = new Lua();

        public ScriptRunner(MainForm form)
        {
            init(form);
        }

        private void init(MainForm form)
        {
            APIBinding binding = new APIBinding(form);
            lua["KSAPI"] = binding;
        }

        public void runScript(string luaScript)
        {
            lua.DoString(luaScript);
        }
    }
}
