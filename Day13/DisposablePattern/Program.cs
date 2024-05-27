using System.Threading.Channels;

class GameController : IDisposable
{
    public List<int> totalPlayers;
    public Dictionary<object, int>allPlayers;
    public ExternalResource externalResource;
    private bool disposed = false; //state for save if Dispose() already called

    protected virtual void Dispose(bool disposing)
    {
        if(!disposed)
        {
            //TODO: dispose managed state (managed objects)
            //Object/Instance
            totalPlayers = null;
            allPlayers = null;
        }
        //TODO: free unmanaged resources (unmanaged objects) and override finalizer
        //TODO: set large field to null
        //External resources object that do not have Dispose()
        externalResource = null;
        disposed = true;
    }

    //TODO: overried finalizer only if "Dispose(bool disposing) has code to free unmanaged resources
    ~GameController()
    {
        //Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        //Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

public class ExternalResource
{

}