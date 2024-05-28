interface ICommunityPool
{
    public bool IsOpen{get;}
    public void OpenCommunityPool(GameState gameState);
    public void CloseCommunityPool();
}