
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public Ball ball;
    public Text p1text;
    public Text p2text;
    private int player1score;
    private int player2score;
    public Paddle1 playPaddle1;
    public Paddle2 playPaddle2;
    

    public void Player1Scores()
    {
        player1score++;
        p1text.text = player1score.ToString();
        ball.Reset();
        playPaddle1.Reset();
        playPaddle2.Reset();

    }
    public void Player2Scores()
    {
        player2score++;
        p2text.text = player2score.ToString();
        ball.Reset();
        playPaddle1.Reset();
        playPaddle2.Reset();
    }
    
    
    
    
}
