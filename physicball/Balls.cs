using Godot;
using System;

public partial class Balls : RigidBody2D
{
	public const float initialVelocity = 20;
	public const float initialX = 0;
	public const float gravity = 9.8f;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		Position = initialX + initialVelocity * delta + 0.5f *  * delta * delta;
	}
}
