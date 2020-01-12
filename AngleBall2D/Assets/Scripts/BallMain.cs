public static class BallMain 
{
    //defenition
    public enum BallStateEnum { shielded,vulnerable};
    //instance
    public static BallStateEnum ballState = BallStateEnum.vulnerable;
    private static float ballSpeed=2;
    private static int points=0;
    private static int lives = 0;



    public static float getBallSpeed()
    {
        return ballSpeed;
    }
    public static void  IncreaseSpeed()
    {
        ballSpeed += 0.2f;
    }
    public static void IncreaseLives()
    {
        points += 1;
    }
    public static int getPoints()
    {
        return points;
    } 
    public static int getLife()
    {
        return lives;
    }
    public static void addLife()
    {
        lives++;
    }
}
