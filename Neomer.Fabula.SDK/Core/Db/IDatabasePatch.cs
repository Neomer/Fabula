using System;
using System.Collections.Generic;
using System.Text;

namespace Neomer.Fabula.SDK.Core.Db
{
    public interface IDatabasePatch
    {
        /// <summary>
        /// Применить изменения патча
        /// </summary>
        void Apply();

        /// <summary>
        /// Откатить изменения патча
        /// </summary>
        void Revert();

    }
}
