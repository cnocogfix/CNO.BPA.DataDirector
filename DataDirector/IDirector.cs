using System;
using System.Runtime.InteropServices;
using CNO.BPA.DataHandler;

namespace CNO.BPA.DataDirector
{
    //Class Interface
    [Guid("350ED3E8-B349-4736-83A3-A8CE5C196B79")]
    public interface IDirector
    {
        event CompleteEventHandler Complete;
        void LaunchDD(ref CommonParameters CP);
    }
    //Events Interface
    [Guid("A52199A8-C355-4ded-80FF-B7DD28111116"),
    InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IDirectorEvents
    {
        void Complete(int Result, string Description);
    }
}
