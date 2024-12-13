using System;

namespace RPG.Class.Item
{
    public abstract class Poder : Acoes
    {
       
        public override string TipoItem { get { return RPG.Class.Enum.EnumTipoItem.Magia.ToString(); } set { } }

    }
}
