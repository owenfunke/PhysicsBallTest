using Godot;
using System;

public partial class Balls : RigidBody2D
{
	public const float initialVelocity = 200; //m/s
	public const float initialX = 0f; //m
	public const float gravity = -9.8f; //m/s^2
	public const float coeffFric = 0.1f;
	public const float ballMass = 10; //kg
	public float positionx = 0f; //m
	

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float time = (float)Time.GetTicksMsec() / 1000; 
		positionx = initialX + initialVelocity * time;
		Position = new Vector2(positionx, Position.Y);
	}
}
